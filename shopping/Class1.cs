using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopping
{
    class Class1
    {
        public static String remove = "http://192.168.199.191:8000/client/deleteGoods/";
        public static String login = "http://192.168.199.191:8000/client/doLogin/";
        public static String add = "http://192.168.199.191:8000/client/addGoods/";
        public static String change = "http://192.168.199.191:8000/client/changeGoodsInfo/";
        public static String goStore = "http://192.168.199.191:8000/client/purchaseGoods/";
        public static String productlist = "http://192.168.199.191:8000/client/goodsList/";
        public static String sell = "http://192.168.199.191:8000/client/sellGoods/";
        public static JObject post(String url,String postDataStr)
        {
            
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            postDataStr = "error=12&" + postDataStr;
            byte[] bytes = Encoding.Default.GetBytes(postDataStr);
            bytes = Encoding.Convert(Encoding.Default, Encoding.UTF8, bytes);
            postDataStr = Encoding.UTF8.GetString(bytes);
            

            StreamWriter writer = new StreamWriter(request.GetRequestStream(), System.Text.Encoding.UTF8);
            writer.Write(postDataStr);
            writer.Flush();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            string encoding = response.ContentEncoding;
            encoding = "UTF-8"; //默认编码
           
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding));
            string retString = reader.ReadToEnd();
            string jsonText = retString;
            JObject jo = (JObject)JsonConvert.DeserializeObject(jsonText);
            
            return jo;
        }
        public static JObject get(String url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            string encoding = response.ContentEncoding;
            if (encoding == null || encoding.Length < 1)
            {
                encoding = "UTF-8"; //默认编码  
            }
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding));
            string retString = reader.ReadToEnd();
            string jsonText = retString;
            JObject jo = (JObject)JsonConvert.DeserializeObject(jsonText);

            return jo;
        }
}
}

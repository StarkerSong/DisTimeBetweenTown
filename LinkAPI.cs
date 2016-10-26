using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DisTimeBetweenTown
{
    class LinkAPI
    {
        public static string RequestApi(string origin, string origin_region, string destination, string destination_region, string mode = "driving")
        {
            string apiUrl = "http://api.map.baidu.com/direction/v1";
            string apiKey = "1c6e0254d1ef1644b087da50e8da14f9"; //
            string output = "json";

            //string origin_region = "北京";
            //string origin = "清华大学";
            //string destination = "北京大学";
            //string destination_region = "北京";
            //string mode = "driving";

            IDictionary<string, string> param = new Dictionary<string, string>();
            param.Add("ak", apiKey);
            param.Add("output", output);
            if (mode == "driving")
            {
                param.Add("origin_region", origin_region);
                param.Add("destination_region", destination_region);
            }
            else
            {
                param.Add("region", origin_region);
            }
            param.Add("origin", origin);
            param.Add("destination", destination);
            param.Add("mode", mode);

            string result = string.Empty;

            //以 Get 形式请求 Api 地址
            result = HttpUtils.DoGet(apiUrl, param);
            return result;
        }

        public static string Output(string origin, string destination, string city)
        {
            string output = "";
            var json = LinkAPI.RequestApi(origin, city, destination, city, "driving");
            JObject jo = JObject.Parse(json);

            if (jo["result"] != null && jo["result"]["routes"] != null)
            {
                output = "时间：" + jo["result"]["routes"][0]["duration"].ToString() + "       距离：" + jo["result"]["routes"][0]["distance"].ToString() ;
            }
            return output;
        }
        
    }
}

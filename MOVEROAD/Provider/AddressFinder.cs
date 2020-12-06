/*
 * COPYRIGHT 2020. MOVEROAD. ALL RIGHTS RESERVED
 */
using Renci.SshNet.Messages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace MOVEROAD
{
    class AddressFinder
    {
        private static AddressFinder instance_ = new AddressFinder();

        public static AddressFinder getInstance()
        {
            return instance_;
        }
        private int getZoneNumber(String input)
        {
            string site = "https://dapi.kakao.com/v2/local/search/address.json?";
            string query = string.Format("{0}query={1}", site, input);
            WebRequest request = WebRequest.Create(query);
            string rkey = "64a77e8ab1b3c27b35576980c8837b24";
            string header = "KakaoAK " + rkey;
            request.Headers.Add("Authorization", header);
            try
            {
                WebResponse response = request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                String json = reader.ReadToEnd();
                stream.Close();
                JavaScriptSerializer js = new JavaScriptSerializer();
                dynamic dob = js.Deserialize<dynamic>(json);
                dynamic docs = dob["documents"];
                object[] buf = docs;
                int length = buf.Length;

                return int.Parse(docs[0]["road_address"]["zone_no"]);
            }
            catch
            {
                return 0;
            }
            
        }
        public List<Address> getZoneList(String input)
        {
            List<Address> Addresses = new List<Address>();
            string site = "https://dapi.kakao.com/v2/local/search/keyword.json?page=1&size=10";
            string query = string.Format("{0}&query={1}", site, input);
            WebRequest request = WebRequest.Create(query);
            string rkey = "64a77e8ab1b3c27b35576980c8837b24";
            string header = "KakaoAK " + rkey;
            request.Headers.Add("Authorization", header);
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            String json = reader.ReadToEnd();
            stream.Close();
            JavaScriptSerializer js = new JavaScriptSerializer();
            dynamic dob = js.Deserialize<dynamic>(json);
            dynamic docs = dob["documents"];
            object[] buf = docs;
            int length = buf.Length;
            for (int i = 0; i < length; i++)
            {
                Address address = new Address(getZoneNumber(docs[i]["road_address_name"]), docs[i]["place_name"], docs[i]["road_address_name"]);
                Addresses.Add(address);
            }
            return Addresses;
        }
    }
}

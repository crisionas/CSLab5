using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace CSLab6
{
    public class ChangeSessionStatus
    {
        public static void Status(string status)
        {

            byte[] requestData = Encoding.UTF8.GetBytes(status);
            Uri myUri = new Uri(string.Format("https://www.browserstack.com/automate/sessions/<session-id>.json"));
            WebRequest myWebRequest = HttpWebRequest.Create(myUri);
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;
            myWebRequest.ContentType = "application/json";
            myWebRequest.Method = "PUT";
            myWebRequest.ContentLength = requestData.Length;
            using (Stream st = myWebRequest.GetRequestStream()) st.Write(requestData, 0, requestData.Length);

            NetworkCredential myNetworkCredential = new NetworkCredential("ionacristian1", "pxWMQstmSVE5fgeKhkHj");
            CredentialCache myCredentialCache = new CredentialCache();
            myCredentialCache.Add(myUri, "Basic", myNetworkCredential);
            myHttpWebRequest.PreAuthenticate = true;
            myHttpWebRequest.Credentials = myCredentialCache;

            myWebRequest.GetResponse().Close();
        }
    }
}

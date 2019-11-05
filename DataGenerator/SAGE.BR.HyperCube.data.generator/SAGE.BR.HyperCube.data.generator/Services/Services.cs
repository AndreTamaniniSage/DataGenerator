using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;

namespace SAGE.BR.HyperCube.data.generator
{
    public class Services
    {
        // POST a JSON string
        public static string POST(string url, string jsonContent)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.Headers.Set("Authorization", ServiceConfig.GetToken());
            request.ContentType = "application/json";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(jsonContent);
            }
            try
            {
                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();

                    return result;
                }
            }
            catch (WebException ex)
            {
                using (var sr = new StreamReader(ex.Response.GetResponseStream()))
                {
                    var data = sr.ReadToEnd();
                    throw new ApplicationException(data);
                }
            }
        }
        public static string PUT(string url, string jsonContent)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "PUT";
            request.Headers.Set("Authorization", ServiceConfig.GetToken());
            request.ContentType = "application/json";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(jsonContent);
            }

            try
            {
                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();

                    return result;
                }
            }
            catch (WebException ex)
            {
                using (var sr = new StreamReader(ex.Response.GetResponseStream()))
                {
                    var data = sr.ReadToEnd();
                    throw new ApplicationException(data);
                }
            }
        }
        public static string GET(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Headers.Set("Authorization", ServiceConfig.GetToken());
            request.ContentType = "application/json";

            var httpResponse = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();

                return result;
            }
        }

    }
}

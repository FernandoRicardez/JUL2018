using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lasallistas.Data
{
    public class Remote
    {
        public delegate void StringCallback(string response, string error);

        #if DEBUG
        public bool UseLocalDemo { get => false; }
        string Server { get => "http://192.168.0.0:8080/api"; }
        //string Server { get => "https://www.pagina.mx/QA/api"; }
        #else
        public bool UseLocalDemo { get => false; }
        string Server { get => "https://www.pagina.mx/api"; }
        #endif
        public string Apiruta { get => Server + "/api/ruta"; }
        public string Apiruta2 { get => Server + "/api/ruta2"; }
        public string ApiGetCancha { get => Server + "/api/api/{canchaId}"; }

        static readonly Remote _shared = new Remote();

        public static Remote Shared => _shared;

        public async Task RequestString(string method, string path, Dictionary<string, string> headers, string data, StringCallback onResponse)
        {
            /*if (!CrossConnectivity.Current.IsConnected)
            {
                onResponse?.Invoke(null, "Sin conexión");
                return;
            }*/
                
            #if __IOS__
            UIKit.UIApplication.SharedApplication.NetworkActivityIndicatorVisible = true;
            #endif
            Console.WriteLine($"{method} {path}");
            var request = WebRequest.CreateHttp(path);
            request.Method = method;

            if (headers != null)
            {
                foreach (var header in headers)
                {
                    Console.WriteLine($"{header.Key}: {header.Value}");
                    if (header.Key == "Content-Type")
                    {
                        request.ContentType = header.Value;
                    }
                    else
                    {
                        request.Headers.Add(header.Key, header.Value);
                    }
                }
            }

            string error = null;
            string stringResponse = null;
            try
            {
                if (data != null)
                {
                    if (headers == null || headers["Content-Type"] == null)
                    {
                        Console.WriteLine("Content-Type: application/x-www-form-urlencoded");
                        request.ContentType = "application/x-www-form-urlencoded";
                    }
                    Console.WriteLine($"DATA: {data}");
                    var bytes = Encoding.UTF8.GetBytes(data);
                    var requestStream = await request.GetRequestStreamAsync();
                    requestStream.Write(bytes, 0, bytes.Length);
                    requestStream.Close();
                }

                var response = await request.GetResponseAsync();
                stringResponse = await new StreamReader(response.GetResponseStream()).ReadToEndAsync();
                Console.WriteLine($"RESPONSE: {stringResponse}\n");
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                error = e.Message;
            }
            #if __IOS__
            UIKit.UIApplication.SharedApplication.NetworkActivityIndicatorVisible = false;
            #endif
            onResponse?.Invoke(stringResponse, error);
        }
    }
}

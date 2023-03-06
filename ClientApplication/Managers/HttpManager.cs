using ClientApplication.Classes;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http.Headers;

namespace ClientApplication.Managers
{
    static class HttpManager
    {
        private static readonly string PingTemplate = "/User/Ping";
        private static readonly string GetPublicKeyTemplate = "/User/Authentication/GetPublicKey?email={0}";
        private static readonly string AuthenticationTemplate = "/User/Authentication/Authenticate?email={0}&password={1}";
        private static readonly string GetDevicesTemplate = "/Device/GetDevices?accessToken={0}";
        private static readonly string GetSensorsTemplate = "/Sensor/GetSensors?accessToken={0}&deviceId={1}";

        private static readonly string uri = "http://10.0.20.2:7443";

        private static readonly HttpClient httpClient = new ();

        public static string Ping()
        {
            HttpResponseMessage response = LoadData(new Uri(uri + PingTemplate));
            if (!ValidateResponse(response))
            {
                return "";
            }
            string content = response.Content.ReadAsStringAsync().Result.Replace("\"", "");

            return content;
        }
        public static string GetPublicKey(string email)
        {
            HttpResponseMessage response = LoadData(new Uri(uri + string.Format(GetPublicKeyTemplate, email)));
            if (!ValidateResponse(response)) {
                return "";
            }
            string content = response.Content.ReadAsStringAsync().Result.Replace("\\n", "");

            content = content.Substring(1, content.Length - 2).Replace("\\","");

            return content;
        }
        public static KeyValuePair<HttpStatusCode,string> Authenticate(string email, string password)
        {
            HttpResponseMessage response = LoadData(new Uri(uri + string.Format(AuthenticationTemplate, email, password)));
            string content = "";
            if (ValidateResponse(response))
            {
                content = response.Content.ReadAsStringAsync().Result.Replace("\"", "");
            }
            return new KeyValuePair<HttpStatusCode, string>(response.StatusCode, content);
        }
        public static void FetchDevices(string accessToken)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            for (int i = 0; i < 5; i++)
            {
                response = LoadData(new Uri(uri + string.Format(GetDevicesTemplate, accessToken)));

                if (ValidateResponse(response))
                {
                    break;
                }
            }

            string content = response.Content.ReadAsStringAsync().Result;

            var objects = JArray.Parse(content);

            foreach (JObject root in objects)
            {
                long id = root["id"].Value<long>();
                string? name = root["name"].Value<string>();
                string? ipv4_adress = root["ipv4_adress"].Value<string>();
                string? real_adress = root["real_adress"].Value<string>();
                string? description = root["description"].Value<string>();
                string? manufacturer = root["manufacturer"].Value<string>();

                Device.devices.Add(new Device(id, name, ipv4_adress, real_adress, description, manufacturer));
            }
        }
        public static void FetchSensors(Device device,string accessToken)
        {
            HttpResponseMessage response = new HttpResponseMessage();

            for (int i = 0; i < 5; i++)
            {
                response = LoadData(new Uri(uri + string.Format(GetSensorsTemplate, accessToken, device.Id)));

                if (ValidateResponse(response))
                {
                    break;
                }
            }

            string content = response.Content.ReadAsStringAsync().Result;

            JArray objects = JArray.Parse(content);

            foreach (JObject root in objects)
            {
                JArray? jData = root["data"] as JArray;
                long id = root["id"].Value<long>();
                string? name = root["name"].Value<string>();
                double[]? data = jData.ToObject<double[]>();
                string? type = root["type"].Value<string>();
                if(type == "Время")
                {
                    device.timeSpan = new Sensor(id, name, data, type);
                } else
                {
                    device.sensors.Add(new Sensor(id, name, data, type));
                }
            }
        }
        static private HttpResponseMessage LoadData(Uri BaseUri)
        {
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = new HttpResponseMessage();
            try
            {
                response = httpClient.GetAsync(BaseUri).Result;
            }
            catch (Exception e)
            {
                FormManager.ShowErrorWindow(e.Message, e.StackTrace);
            }
            return response;
        }
        static private bool ValidateResponse(HttpResponseMessage response)
        {
            switch (response.StatusCode)
            {
                case HttpStatusCode.OK:
                    return true;
                case HttpStatusCode.Created:
                    return true;
                case HttpStatusCode.MultipleChoices:
                    return true;
                case HttpStatusCode.BadRequest:
                    FormManager.ShowErrorWindow(response.StatusCode.ToString(), response.ToString());
                    break;
                case HttpStatusCode.Unauthorized:
                    FormManager.ShowErrorWindow(response.StatusCode.ToString(), response.ToString());
                    break;
                case HttpStatusCode.NotFound:
                    FormManager.ShowErrorWindow(response.StatusCode.ToString(), response.ToString());
                    break;
                case HttpStatusCode.NotAcceptable:
                    FormManager.ShowErrorWindow(response.StatusCode.ToString(), response.ToString());
                    break;
                case HttpStatusCode.InternalServerError:
                    FormManager.ShowErrorWindow(response.StatusCode.ToString(), response.ToString());
                    break;
                case HttpStatusCode.BadGateway:
                    FormManager.ShowErrorWindow(response.StatusCode.ToString(), response.ToString());
                    break;
                case HttpStatusCode.ServiceUnavailable:
                    FormManager.ShowErrorWindow(response.StatusCode.ToString(), response.ToString());
                    break;
                case HttpStatusCode.GatewayTimeout:
                    FormManager.ShowErrorWindow(response.StatusCode.ToString(), response.ToString());
                    break;
                case HttpStatusCode.NotExtended:
                    FormManager.ShowErrorWindow(response.StatusCode.ToString(), response.ToString());
                    break;
            }
            return false;
        }
    }
}

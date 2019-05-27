using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace Factura_Electronica.Models
{
    public class Usuario
    {
        class TokenenJson
        {
            [JsonProperty("access_token")]
            public string access_token { get; set; }

            [JsonProperty("refresh_token")]
            public string refresh_token { get; set; }
        }
        
        public async void Obtienetokendehacienda() 
{
 try 
{
string Tipodeambiente = "api-stag";
string URL_parasolicituddeltoken = "https://idp.comprobanteselectronicos.go.cr/auth/realms/rut-stag/protocol/openid-connect/token"; 
HttpClient clientetipohttp = new HttpClient();
List<KeyValuePair<string, string>> parametros = new List<KeyValuePair<string, string>>();
parametros.Add(new KeyValuePair<string, string>("client_id", Tipodeambiente));
parametros.Add(new KeyValuePair<string, string>("grant_type", "password")); 
parametros.Add(new KeyValuePair<string, string>("username", this.id)); 
parametros.Add(new KeyValuePair<string, string>("password", this.clave));
FormUrlEncodedContent content = new FormUrlEncodedContent(parametros); 

HttpResponseMessage response = clientetipohttp.PostAsync(URL_parasolicituddeltoken, content).Result; 
string respuesta = await response.Content.ReadAsStringAsync(); 


var objetorecibidodehacienda = Newtonsoft.Json.JsonConvert.DeserializeObject<TokenenJson>(respuesta);
this.token = objetorecibidodehacienda.access_token; 

if ((response.StatusCode != System.Net.HttpStatusCode.OK)) 
{
throw new Exception(("Error:" + response.GetHashCode())); 
}
}
catch (Exception ex) 
{
throw ex; 
}
}
        String id,clave,token;
        X509Certificate2 CertificadoDigital;

        public X509Certificate2 CertificadoDigital1
        {
            get { return CertificadoDigital; }
            set { CertificadoDigital = value; }
        }

public String Token
{
  get { return token; }
  set { token = value; }
}public String Clave
{
  get { return clave; }
  set { clave = value; }
}public String Id
{
  get { return id; }
  set { id = value; }
}
    public Usuario()
{

}
    }
}
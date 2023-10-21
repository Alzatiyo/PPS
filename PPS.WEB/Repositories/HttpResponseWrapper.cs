using System.Net;

namespace PPS.WEB.Repositories
{
    public class HttpResponseWrapper<T>
    {
        public HttpResponseWrapper(T? response, bool error, HttpResponseMessage httpResponseMessage) 
        {
            Error = error;
            Response = response;
            HttpResponseMessage = httpResponseMessage;
        }
        public bool Error { get; set; }
        public T? Response { get; set; }
        public HttpResponseMessage HttpResponseMessage { get; set;}
        
        public async Task<string?> GetErrorMessage()
        {
            var codigoEstatus = HttpResponseMessage.StatusCode;

            if (!Error)
            {
                return null;
            }           
            if (codigoEstatus == HttpStatusCode.NotFound)
            {
                return "Recurso no encontrado";
            }
            else if(codigoEstatus == HttpStatusCode.BadRequest)
            {
                return await HttpResponseMessage.Content.ReadAsStringAsync();
            }                  
            else if(codigoEstatus == HttpStatusCode.Unauthorized)
            {
                return "Debes Loguearte para realizar esta accion";
            }
            else if (codigoEstatus == HttpStatusCode.Forbidden)
            {
                return "No tienes permisos para ejecutar esta accion";
            }

            return "ha ocurrido un error inesperado";
        }
    }
}

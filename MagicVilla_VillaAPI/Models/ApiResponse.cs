using System.Net;

namespace MagicVilla_VillaAPI.Models
{
    public class ApiResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSucces { get; set; } = true;
        public List<string> ErrorsMessages{ get; set; }
        public object Result { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
#nullable disable
namespace API.Error
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }


        public int StatusCode { get; set; }
        public string  Message { get; set; }
        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A Bad Request, You Have Made",
                401 => "Authorized, You Are Not",
                404 => "Resoure Found, It Was Not",
                500 => "Errors Are The Path To The Dark Side. Errors Lead To Anger. Anger Leads To Hate . Hate Leads To Career Change",
                _ => null
            };
        }
    }
}
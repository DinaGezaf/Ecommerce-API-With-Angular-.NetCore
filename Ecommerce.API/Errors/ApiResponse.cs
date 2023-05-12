namespace Ecommerce.API.Errors
{
    public class ApiResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; } = string.Empty;
        public ApiResponse(int statusCode,string message=null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDeFaultMessageForStatusCode(StatusCode);
        }
        private string GetDeFaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "Bad Request, you have made",
                401=>"Authorized you are not",
                404 => "Response found is not",
                500 => "Server Error Occured",
                _=>null
            };
        }
    }
}

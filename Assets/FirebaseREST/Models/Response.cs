using System.Collections.Generic;

namespace FirebaseREST
{
    public class Response<T> : Response
    {
        public new T data;
        public Response(Dictionary<string, string> headers, string message, bool success, int code, T data = default(T)) : base(headers, message, success, code, null)
        {
            this.data = data;
        }
    }

    public class Response
    {
        public string message;
        public bool success;
        public int code;
        public string data;
        public Dictionary<string, string> headers;

        public Response(Dictionary<string, string> headers, string message, bool success, int code, string data)
        {
            this.headers = headers;
            this.message = message;
            this.success = success;
            this.code = code;
            this.data = data;
        }
    }

    public enum ResponseCode
    {
        CANCELLED = -199,
        TIMEOUT = -200,
        SUCCESS = 200,
    }
}
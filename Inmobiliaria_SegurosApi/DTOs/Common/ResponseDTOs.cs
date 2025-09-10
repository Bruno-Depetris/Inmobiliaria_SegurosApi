namespace Inmobiliaria_SegurosApi.DTOs.Common {
    public class ResponseDTOs<T> {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public T? Data { get; set; }
        public List<string> Errors { get; set; } = new List<string>();

        public static ResponseDTOs<T> SuccessResult(T data, string message = "Operación exitosa") {
            return new ResponseDTOs<T> {
                Success = true,
                Message = message,
                Data = data
            };
        }

        public static ResponseDTOs<T> ErrorResult(string message, List<string>? errors = null) {
            return new ResponseDTOs<T> {
                Success = false,
                Message = message,
                Errors = errors ?? new List<string>()
            };
        }
    }
}

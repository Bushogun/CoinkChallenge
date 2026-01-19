namespace Core.Dtos.ResponsesDto
{
    public class Result
    {
        public bool Success { get; protected set; }
        public string? Message { get; set; }

        public Result() : base() { }

        protected Result(bool success, string? message = null)
        {
            Success = success;
            Message = message;
        }

        public static Result Ok(string? message = null)
            => new(true, message);

        public static Result Fail(string message)
            => new(false, message);
    }

    public class Result<T> : Result
    {
        public T? Data { get; private set; }
        public int TotalRecords { get; private set; }

        private Result(bool success, T? data, int totalRecords, string? message)
            : base(success, message)
        {
            Data = data;
            TotalRecords = totalRecords;
        }
        public static Result<T> Success(T data, int totalRecords = 0)
            => new(true, data, totalRecords, null);

        public static Result<T> Failure(string message)
            => new(false, default, 0, message);
    }
}
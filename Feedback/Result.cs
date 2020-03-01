using System;

namespace Feedback
{
    public class Result<T>
    {
        private readonly bool success;
        private readonly T value;
        private readonly string message;
        private readonly int code;

        public bool Success => success;

        public T Value => value;

        public string Message => message;

        public int Code => code;

        public Result(bool success, T value, string message, int code)
        {
            this.success = success;
            this.value = value;
            this.message = message;
            this.code = code;
        }

        public static Result<T> CreateSuccess(T value, string message = null, int code = 0)
        {
            return new Result<T>(true, value, message, code);
        }

        public static Result<T> CreateFailure(string message, int code = 0)
        {
            return new Result<T>(false, default(T), message, code);
        }

        public static implicit operator T(Result<T> result)
        {
            return result.Value;
            // if (result.Success)
            // else 
            //    return default(T);
        }
    }
}

using System;
namespace dotnet_tutorial.Models
{
    public class ServiceResponse<T> //Type
    {
        public T Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = null;

    }
}

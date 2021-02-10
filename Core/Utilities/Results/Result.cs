using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        

        public Result(bool success, string message):this(success)
        {   //  :this(success) kodu ile alt bloktakini çalıştırmış olacak
            // 2 parametre aldığında hem bu blok hemde alttaki blok çalışssın
            Message = message;
            //Success = success; Bu blok success alt bloktakini kapsadığı için kaldırdık.
        }
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}

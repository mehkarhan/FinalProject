using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data,string message):base(data,true,message)
        {
            //data ve mesaj
        }
        public SuccessDataResult(T data):base(data,true)
        {
            // sadece data
        }
        public SuccessDataResult(string message):base(default,true,message)
        {
            //sadece message
            //default, data için kullanıyoruz.  gönderdiği datanın default değeri döndürür.
        }
        public SuccessDataResult():base(default,true)
        {

        }
    }
}

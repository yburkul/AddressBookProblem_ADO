using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystemADO
{
    public class AddressException : Exception
    {

        ExceptionType exceptionType;
        public enum ExceptionType
        {
            Connection_Failed, Contact_Not_Add,Contact_Not_Edit,Contact_Not_Delete
        }
        public AddressException(ExceptionType exceptionType, string message) : base(message)
        {
            this.exceptionType = exceptionType;
        }
    }
}
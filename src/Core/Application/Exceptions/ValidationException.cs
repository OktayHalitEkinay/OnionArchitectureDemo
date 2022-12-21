using Application.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class ValidationException:Exception
    {
        

        public ValidationException():this(Messages.validationErrorOccured){}
        public ValidationException(string message):base(message){}
        public ValidationException(Exception ex):this(ex.Message){}
    }
}

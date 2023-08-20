using EtradeOrderModule.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtradeOrderModule.Application.Exceptions
{
    public class UpdateControlException : BaseException
    {
        public UpdateControlException() : base("A deleted order cannot be updated. please create new order")
        {
        }
    }
}

using EtradeOrderModule.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtradeOrderModule.Application.Exceptions
{
    public class NotFoundOrderException : BaseException
    {
        public NotFoundOrderException() : base("Order not found")
        {
        }
    }
}

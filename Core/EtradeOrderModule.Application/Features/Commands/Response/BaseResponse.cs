using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtradeOrderModule.Application.Features.Commands.Response
{
    public abstract class BaseResponse
    {
        public bool Succeeded { get; set; } = true;
        public string Message { get; set; }
    }
}

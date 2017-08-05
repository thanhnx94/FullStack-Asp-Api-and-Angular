using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd_Api.Models
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string Message) : base(Message)
        {

        }
    }

    public class ForbiddenException : Exception
    {
        public ForbiddenException(string Message) : base(Message)
        {

        }
    }

    public class NotFoundException : Exception
    {
        public NotFoundException(string Message) : base(Message)
        {

        }
    }

    public class ConflictException : Exception
    {
        public ConflictException(string Message) : base(Message)
        {

        }
    }
}
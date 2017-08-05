using BackEnd_Api.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace BackEnd_Api
{
    public class ExceptionResponseAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.BadRequest);
            if (context.Exception is BadRequestException)
            {
                response = new HttpResponseMessage(HttpStatusCode.BadRequest);
                response.ReasonPhrase = "Wrong paramenters";

            }
            if (context.Exception is ConflictException)
            {
                response = new HttpResponseMessage(HttpStatusCode.Conflict);
                response.ReasonPhrase = "Conflict data";
            }

            if (context.Exception is ForbiddenException)
            {
                response = new HttpResponseMessage(HttpStatusCode.Forbidden);
                response.ReasonPhrase = "Forbidden";
            }
            if (context.Exception is NotFoundException)
            {
                response = new HttpResponseMessage(HttpStatusCode.NotFound);
                response.ReasonPhrase = "Not Found";
            }

            string Message = JsonConvert.SerializeObject(new { Message = context.Exception.Message });
            response.Content = new StringContent(Message);
            context.Response = response;
        }
    }
}
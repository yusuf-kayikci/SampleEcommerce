using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SampleEcommerce.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SampleEcommerce.BasketApi.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next; public ExceptionMiddleware(RequestDelegate next)
        {
            this._next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            string errorMessage = string.Empty; try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                var exType = ex.GetBaseException();
                // ... Add logger
                context.Response.StatusCode = (int)GetErrorCode(exType);
                context.Response.ContentType = "application/json";

                await context.Response.WriteAsync(JsonConvert.SerializeObject(new ProblemDetails()
                {
                    Status = context.Response.StatusCode,
                    Title = ex.Message
                } , new JsonSerializerSettings { 
                    NullValueHandling = NullValueHandling.Ignore
                }));
            }
        }
        private static HttpStatusCode GetErrorCode(Exception e)
        {
            switch (e)
            {
                case NotImplementedException _:
                    return HttpStatusCode.NotImplemented;
                case SampleEcommerceException _:
                    return HttpStatusCode.BadRequest;
                default:
                    return HttpStatusCode.InternalServerError;
            }
        }
    }

}


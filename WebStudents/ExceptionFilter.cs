using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebStudents;

public class ExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        var (status, message) = context.Exception switch
        {
            FileNotFoundException => (404,"Resource was not found"),
            _ => (500, "Unknown server error"),
        };
        context.Result = new JsonResult(new { Message = message}) { StatusCode = status };
    }
}
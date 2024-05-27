namespace Project_api.Middlewares
{
    public class ShabbatMiddleware
    {
        private readonly RequestDelegate _next;

        public ShabbatMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("middleware start :: " + context.Items["guid"]);
            var shabbat = DateTime.Now.Day;

            if (shabbat==7)
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                return;
            }
            // Do work that can write to the Response.
            await _next(context);
            Console.WriteLine("middleware end :: " + context.Items["guid"]);
            // Do logging or other work that doesn't write to the Response.
        }
    }
}

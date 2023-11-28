using RestEncuestasAPI.Data;

namespace RestEncuestasAPI.Extensions
{
    public static class DatabaseContextExtentions
    {
        public static WebApplication EnsureDbCreated(this WebApplication app)
        {
            try
            {
                using (var scope = app.Services.CreateScope())
                {
                    var encuestasDbContext = scope.ServiceProvider.GetService<EncuestaContext>();

                    if (encuestasDbContext is not null)
                    {
                        encuestasDbContext.Database.EnsureCreated();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return app;
        }
    }
}

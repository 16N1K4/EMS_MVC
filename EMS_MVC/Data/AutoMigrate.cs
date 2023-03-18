using Microsoft.EntityFrameworkCore;

namespace EMS_MVC.Data
{
    public static class AutoMigrate
    {
        public static void AutoMigration(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                using (var appContext = scope.ServiceProvider.GetRequiredService<EMSContext>())
                {
                    try
                    {
                        appContext.Database.Migrate(); // migration are there in the assembly update them on the database.
                    }
                    catch (Exception ex)
                    {
                        //Log errors or do anything you think it's needed
                        throw;
                    }
                }
            }
        }
    }
}

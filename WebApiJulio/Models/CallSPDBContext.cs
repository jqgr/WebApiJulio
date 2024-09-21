using Microsoft.EntityFrameworkCore;

namespace WebApiJulio.Models
{
    public class CallSPDBContext:DbContext
    {
        protected readonly IConfiguration Configuration;

        public CallSPDBContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<SalesDatePrediction> SalesDatePrediction {  get; set; }
        public DbSet<ClientOrders> ClientOrders {  get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace projeto1.Models
{

    public class ClienteContext : DbContext
    {

        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options)
        {


        }

    }
    
}
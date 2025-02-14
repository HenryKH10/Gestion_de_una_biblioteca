using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace Gestión_de_una_biblioteca.Models
{
    public class equiposContex: DbContext
    {
        public equiposContex(DbContextOptions<equiposContex>options) : base(options)
        { 
         
        }

    }
}

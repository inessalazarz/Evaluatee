using System.Data.Entity;

namespace webEval.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection2")
        {

        }

        public System.Data.Entity.DbSet<webEval.Models.Eval> Evals { get; set; }
    }
}
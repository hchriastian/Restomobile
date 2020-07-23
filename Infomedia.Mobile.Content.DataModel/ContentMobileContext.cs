using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Infomedia.Mobile.Content.DataModel
{
    public class ContentMobileContext<T> : DbContext where T : class
    {
        public ContentMobileContext()
            : base("name=dbRestoMobileEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        private DbSet<T> _dbEntities;

        /// <summary>
        /// Entities contained by this repository.
        /// </summary>        
        public DbSet<T> DBEntities
        {
            get { return _dbEntities ?? (_dbEntities = this.Set<T>()); }
        }
    }
}

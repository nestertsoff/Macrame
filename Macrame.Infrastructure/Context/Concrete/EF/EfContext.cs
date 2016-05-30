namespace Macrame.Infrastructure.Context.Concrete.EF
{
    using System.Data.Entity;

    using Macrame.Domain.Entities.Abstract;
    using Macrame.Domain.Entities.Concrete.Items.Additional;
    using Macrame.Domain.Entities.Concrete.Items.DateTime;
    using Macrame.Infrastructure.Context.Abstract;

    public class EfContext : DbContext, IContext
    {
        public EfContext()
            : base("DbConnection")
        {
        }

        public EfContext(string connectionString)
            : base(connectionString)
        {
            Configuration.ProxyCreationEnabled = false;
        }

        public IDbSet<CategoryItem> CategoryItems { get; set; }

        public IDbSet<ColorItem> ColorItems { get; set; }

        public IDbSet<DateTimeItem> DateTimeItems { get; set; }

        public IDbSet<ImageItem> ImageItems { get; set; }

        public IDbSet<LinkItem> LinkItems { get; set; }

        public IDbSet<MoneyItem> MoneyItems { get; set; }

        public IDbSet<PhoneNumberItem> PhoneNumberItems { get; set; }

        public IDbSet<RatingItem> RatingItems { get; set; }

        public IDbSet<TextItem> TextItems { get; set; }

        public IDbSet<TEntity> Set<TEntity, TPrimaryKey>() where TEntity : class, IEntity<TPrimaryKey>
        {
            return Set<TEntity>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // modelBuilder.Configurations.Add(new GameConfiguration());
            // modelBuilder.Configurations.Add(new CommentConfiguration());
            // modelBuilder.Configurations.Add(new GenreConfiguration());
            // modelBuilder.Configurations.Add(new PlatformTypeConfiguration());
            // modelBuilder.Configurations.Add(new PublisherConfiguration());
            // modelBuilder.Configurations.Add(new OrderConfiguration());
            // modelBuilder.Configurations.Add(new OrderDetailsConfiguration());
        }
    }
}
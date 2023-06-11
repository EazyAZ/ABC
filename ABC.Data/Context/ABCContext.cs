namespace ABC.Data.Context;

public partial class ABCContext : DbContext
{
    //private readonly IConfiguration _configuration;

    //public ABCContext(IConfiguration configuration)
    //{
    //    _configuration = configuration;
    //}

    public ABCContext(DbContextOptions<ABCContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //if (!optionsBuilder.IsConfigured)
        //{
        //    optionsBuilder.UseSqlServer(_configuration[ConfigurationConstants.DefaultConnectionStringName]);
        //}
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

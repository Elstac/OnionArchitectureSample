namespace OnionArchitectureSample.Infrastructure
{
    class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext context;

        public UnitOfWork(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void SeveChanges()
        {
            context.SaveChanges();
        }
    }
}

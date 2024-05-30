namespace Spg.Spengergram.DomainModel.Interfaces.Repository
{
    public interface IEntityUpdateBuilder<TEntity>
        where TEntity : class
    {
        public TEntity Entity { get; set; }
        int Save();
    }
}

namespace SpendFlix.Data.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly ISpendFlixContext _spendFlixContext;
        public AdminRepository(ISpendFlixContext _spendFlixContext)
        {
            this._spendFlixContext = _spendFlixContext;
        }
    }
}

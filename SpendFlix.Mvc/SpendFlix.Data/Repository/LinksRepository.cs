using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpendFlix.Data.Repository
{
    public class LinksRepository :ILinksRepository
    {
        private readonly ISpendFlixContext _spendFlixContext;
        public LinksRepository(ISpendFlixContext _spendFlixContext)
        {
            this._spendFlixContext = _spendFlixContext;
        }
    }
}

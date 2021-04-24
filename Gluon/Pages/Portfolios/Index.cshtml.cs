using Gluon.Models;
using Gluon.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Gluon.Pages.Portfolios
{
    public class IndexModel : PageModel
    {
        private readonly PortfolioServiceJsonFile _service;

        // 生成者のパラメータでサービス(レポジトリ)クラス注入
        public IndexModel(PortfolioServiceJsonFile service)
        {
            _service = service;
        }

        public IEnumerable<Portfolio> Portfolios { get; private set; }
        public void OnGet()
        {
            Portfolios = _service.GetPortfolios();
            Portfolios = _service.GetPortfolios();
        }
    }
}

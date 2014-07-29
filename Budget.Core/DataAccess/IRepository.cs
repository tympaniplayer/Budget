using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.Core.DataAccess
{
    public interface IRepository
    {
        BudgetMonth GetBudgetMonth(Guid id);
        void SaveBudgetMonth(BudgetMonth month);
        void DeleteBudgetMonth(Guid id);
        IEnumerable<BudgetMonth> GetMonths();

        BudgetLine GetBudgetLine (Guid id);
        void SaveBudgetLine(BudgetLine line);
        void DeleteBudgetLine(Guid id);
        IEnumerable<BudgetLine> GetLinesForHeader(Guid headerId);

        BudgetHeader GetBudgetHeader(Guid id);
        void SaveBudgetHeader(BudgetHeader header);
        void DeleteBudgetHeader(Guid id);
        IEnumerable<BudgetHeader> GetHeadersForMonth(Guid monthId);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.History
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public Guid BudgetMonthId { get; set; }
        public Guid BudgetHeaderId { get; set; }
        public Guid BudgetLineId { get; set; }
        public Guid? ExpenseLineId { get; set; }
        public string Message { get; set; }
        public DateTime DateModified { get; set; }
    }
}

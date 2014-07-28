using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.Core
{
    public class BudgetMonth
    {
        /// <summary>
        /// The id of the Budget Month
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// The month and year of the budget
        /// </summary>
        public DateTime BudgetMonth { get; set; }
        /// <summary>
        /// The budget headers for the month
        /// </summary>
        public List<BudgetHeader> BudgetLines { get; set; }
        /// <summary>
        /// The amount of income for the month
        /// </summary>
        public decimal Income { get; set; }
        /// <summary>
        /// The amount budgeted for the month
        /// </summary>
        public decimal AmountBudgeted { get; set; }
        /// <summary>
        /// The amount remaining for the month
        /// </summary>
        public decimal AmountRemaining { get; set; }
        /// <summary>
        /// True if the Income - AmountBudgeted == 0
        /// </summary>
        public bool ZeroBased { get; set; }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Budget.Core
{
    public class BudgetHeader
    {
        /// <summary>
        /// The id for the budget header
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The name of the budget header
        /// <example>"Housing", "Loans"</example>
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The list of budget lines for the budget header
        /// </summary>
        public List<BudgetLine> BudgetLines { get; set; }

        public BudgetMonth BudgetMonth { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Budget.Core
{
    public class ExpenseLine
    {
        /// <summary>
        /// The Id of the expense line
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// The budget line the expense belongs too
        /// </summary>
        public BudgetLine BudgetItem { get; set; }
        /// <summary>
        /// The date of the expense
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// The amount spent
        /// </summary>
        public decimal AmountSpent { get; set; }
        /// <summary>
        /// Any comments on the expense
        /// </summary>
        public string Comments { get; set; }
    }
}

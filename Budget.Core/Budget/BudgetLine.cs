using Budget.History;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Budget.Core
{
    public class BudgetLine
    {
        private Logger logger;
        public BudgetLine()
        {
            logger = new Logger();
        }
        /// <summary>
        /// The id of the budget line
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// The name of the budget line
        /// <example>"Mortgage Payment", "Student Loan"</example>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The budget header that the budget line falls under
        /// </summary>
        public BudgetHeader BudgetHeaderParent { get; set; }

        /// <summary>
        /// The amount budgeted for the month
        /// </summary>
        public decimal BudgetedAmount { get; private set; }
        /// <summary>
        /// The amount spent so far
        /// </summary>
        public decimal AmountSpent { get; private set; }
        /// <summary>
        /// The remaining amount for the rest of the month
        /// </summary>
        public decimal AmountRemaining
        {
            get
            {
                return BudgetedAmount - AmountSpent;
            }
        }
        /// <summary>
        /// The list of expenses for the budget line
        /// </summary>
        public List<ExpenseLine> Expenses { get; set; }

        public void AddExpense (ExpenseLine expense)
        {
            Expenses.Add(expense);
            AmountSpent += expense.AmountSpent;
            Log(string.Format("Expense added for {0}, amount {1}", Name, expense.AmountSpent));
        }
        public void ChangeBudgetedAmount(decimal amount)
        {            
            BudgetedAmount = amount;
            Log(string.Format("Budget amount changed to {0}", amount.ToString("$#,##0.00")));
        }
        public void DeleteExpense (Guid Id)
        {
            var expenseToDelete = Expenses.Single(t => t.Id == Id);
            Expenses.Remove(expenseToDelete);
        }
        private void Log(string message, ExpenseLine expense = null)
        {
            var transaction = new Transaction
            {
                BudgetHeaderId = BudgetHeaderParent.Id,
                BudgetMonthId = BudgetHeaderParent.BudgetMonth.Id,
                BudgetLineId = Id,
                Message = message,
                DateModified = DateTime.Now
            };
            if (expense != null)
            {
                transaction.ExpenseLineId = expense.Id;
            }
            logger.LogTransaction(transaction);
        }
    }
}

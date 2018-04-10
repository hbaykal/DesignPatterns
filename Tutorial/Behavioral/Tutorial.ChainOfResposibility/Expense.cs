using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.ChainOfResposibility
{
    public class Expense
    {
        public string Detail { get; set; }
        public decimal Price { get; set; }
    }

    public abstract class ExpenseHandlerBase
    {
        protected ExpenseHandlerBase Successor;
        public abstract void HandleExpense(Expense expense);
        public void SetSuccessor(ExpenseHandlerBase successor )
        {
            Successor = successor;
        }
    }

    public class Manager : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Price <= 100)
            {
                Console.WriteLine("Manager handled expense");
            }
            else if(Successor != null)
            {
                Successor.HandleExpense(expense);
            }
        }
    }

    public class VicePresident : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Price > 100 && expense.Price <=1000)
            {
                Console.WriteLine("Vice President handled expense");
            }
            else if (Successor != null)
            {
                Successor.HandleExpense(expense);
            }
        }
    }

    public class President : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Price > 1000)
            {
                Console.WriteLine("President handled expense");
            }
        }
    }
}

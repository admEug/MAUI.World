using ProsperDaily.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProsperDaily.MVVM.ViewModels
{
     public class TransactionsViewModel
     {
          public Transaction  Transaction { get; set; } = new Transaction
          {
               OperationDate = DateTime.Now,
          };




          public string SaveTransaction()
          {
               App.TransactionsRepo.SaveItem(Transaction);
               return App.TransactionsRepo.StatusMessage;
          }
     }
}

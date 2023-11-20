using System.Collections.ObjectModel;
using Tasker.MVVM.Models;

namespace Tasker.MVVM.ViewModels
{
	public class NewTaskViewModel
     {
          public string Task { get; set; }
          public ObservableCollection<MyTask> Tasks { get; set; }
          public ObservableCollection<Category> Categories { get; set; }

     }
}

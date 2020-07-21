using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BlazorApp.Areas.Identity.Pages.Account
{
    internal class Command<T> : ICommand
    {
        private Func<string, Task<IActionResult>> onPostAsync;

        public Command(Func<string, Task<IActionResult>> onPostAsync)
        {
            this.onPostAsync = onPostAsync;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            onPostAsync.Invoke(parameter.ToString());
        }
    }
}
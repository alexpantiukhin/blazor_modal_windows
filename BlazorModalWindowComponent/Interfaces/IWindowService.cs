using System;
using System.Threading.Tasks;

namespace BlazorModalWindowComponent.Interfaces
{
    public interface IWindowService <TModel>
    {
        event Func<TModel, string, Task> OnShow;
        Task Close();
        Task ClosedCall();
        Task ShowedCall();
    }
}

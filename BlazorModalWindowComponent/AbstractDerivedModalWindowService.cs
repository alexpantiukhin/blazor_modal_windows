using System;
using System.Threading.Tasks;

namespace BlazorModalWindowComponent
{
    /// <summary>
    /// Абстрактный класс для производных классов
    /// </summary>
    public abstract class AbstractDerivedModalWindowService
    {
        public event Func<Task> OnShowed;
        public event Func<Task> OnClosed;
        public event Func<Task> OnClose;

        public async Task ShowedCall()
        {
            if (OnShowed != null)
                await OnShowed?.Invoke();
            //return OnShowed?.Invoke();
        }
        public async Task ClosedCall()
        {
            if (OnClosed != null)
                await OnClosed?.Invoke();
        }
        public async Task Close()
        {
            if (OnClose != null)
                await OnClose?.Invoke();
            //return OnClose?.Invoke();
        }

    }
}

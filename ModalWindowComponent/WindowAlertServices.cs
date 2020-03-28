using ModalWindowComponent;

using System;
using System.Threading.Tasks;

namespace BlazorModalWindowComponent
{
    public class WindowAlertServices : AbstractDerivedModalWindowService
    {
        public event Func<WindowAlertModel, Task> OnShow;

        public Task Show(Action actionOk, string message = null, string title = null, string buttonOkText = null)
        {
            var model = new WindowAlertModel
            {
                ActionOk = actionOk,
                ButtonOkText = buttonOkText,
                Message = message,
                Title = title
            };

            return OnShow?.Invoke(model);
            //if (OnShow != null)
            //    await OnShow.Invoke();
        }

        //public async Task Close()
        //{
        //    await _modalWindowService.Close();

        //    //if (OnClose != null)
        //    //    await OnClose.Invoke();
        //}

    }
}

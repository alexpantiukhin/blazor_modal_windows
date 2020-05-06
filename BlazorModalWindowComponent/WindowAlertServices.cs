using System;
using System.Threading.Tasks;

namespace BlazorModalWindowComponent
{
    public class WindowAlertServices : AbstractDerivedModalWindowService<WindowAlertModel>
    {
        public Task Show(Func<Task> actionOk, string message = null, string title = null, string buttonOkText = null, string containerClass = null)
        {
            var model = new WindowAlertModel
            {
                ActionOk = actionOk,
                ButtonOkText = buttonOkText,
                Message = message,
                Title = title
            };

            return CallOnShow(model, containerClass);
        }
    }
}

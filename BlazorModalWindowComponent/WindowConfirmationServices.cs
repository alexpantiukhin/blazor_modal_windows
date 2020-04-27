using System;
using System.Threading.Tasks;

namespace BlazorModalWindowComponent
{
    public class WindowConfirmationServices : AbstractDerivedModalWindowService<WindowConfirmationModel>
    {
        public Task Show(Action actionTrue, string message = null, Action actionFalse = null, string title = null, string buttonTrueText = null, string buttonFalseText = null, string containerClass = null)
        {
            var model = new WindowConfirmationModel
            {
                ActionFalse = actionFalse,
                ActionTrue = actionTrue,
                ButtonFalseText = buttonFalseText,
                ButtonTrueText = buttonTrueText,
                Message = message,
                Title = title
            };

            return CallOnShow(model, containerClass);
        }
    }
}

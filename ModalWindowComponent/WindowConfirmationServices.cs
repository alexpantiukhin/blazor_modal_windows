using ModalWindowComponent;

using System;
using System.Threading.Tasks;

namespace ModalWindowConfirmationComponent
{
    public class WindowConfirmationServices : AbstractDerivedModalWindowService
    {
        public event Func<WindowConfirmationModel, Task> OnShow;

        public Task Show(Action actionTrue, string message = null, Action actionFalse = null, string title = null, string buttonTrueText = null, string buttonFalseText = null)
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

            return OnShow?.Invoke(model);
        }
    }
}

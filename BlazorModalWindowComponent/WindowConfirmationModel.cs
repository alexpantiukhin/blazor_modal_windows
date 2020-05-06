using BlazorModalWindowComponent.Interfaces;

using System;
using System.Threading.Tasks;

namespace BlazorModalWindowComponent
{
    public class WindowConfirmationModel : IWindowWithContainerModel
    {
        public Func<Task> ActionTrue { get; set; }
        public Func<Task> ActionFalse { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string ButtonTrueText { get; set; }
        public string ButtonFalseText { get; set; }
    }
}

using BlazorModalWindowComponent.Interfaces;

using System;
using System.Threading.Tasks;

namespace BlazorModalWindowComponent
{
    public class WindowAlertModel : IWindowWithContainerModel
    {
        public Func<Task> ActionOk { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string ButtonOkText { get; set; }
    }
}

using BlazorModalWindowComponent.Interfaces;

using System;

namespace BlazorModalWindowComponent
{
    public class WindowAlertModel : IWindowWithContainerModel
    {
        public Action ActionOk { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string ButtonOkText { get; set; }
    }
}

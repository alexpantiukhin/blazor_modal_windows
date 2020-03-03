using System;

namespace BlazorModalWindowComponent
{
    public class WindowConfirmationModel
    {
        public Action ActionTrue { get; set; }
        public Action ActionFalse { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string ButtonTrueText { get; set; }
        public string ButtonFalseText { get; set; }
    }
}

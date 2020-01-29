using System;

namespace ModalWindowAlertComponent
{
    public class WindowAlertModel
    {
        public Action ActionOk { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string ButtonOkText { get; set; }
    }
}

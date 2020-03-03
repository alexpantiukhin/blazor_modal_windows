using System;
using System.Collections.Generic;
using System.Text;

namespace ModalWindowComponent.Interfaces
{
    public interface IModalWindow <TModel>
    {
        TModel Model { get; set; }
    }
}

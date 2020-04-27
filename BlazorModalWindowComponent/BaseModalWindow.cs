using Microsoft.AspNetCore.Components;

using System.Threading.Tasks;

namespace BlazorModalWindowComponent
{
    public class BaseModalWindow : ComponentBase
    {
        [Parameter]
        public string ContainerClass { get; set; }
        [Parameter]
        public bool IsVisible { get; set; }
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        protected virtual RenderFragment Content(RenderFragment childContent = null)
        {
            return x =>
            {
                x.OpenElement(0, "div");

                var classString = Texts.ModalContainerClass + " "
                    + (IsVisible ? Texts.ModalActiveContainerClass : string.Empty) + " "
                    + ContainerClass;

                x.AddAttribute(1, "class", classString);

                x.AddContent(2, childContent ?? ChildContent);
                x.CloseElement();
            };
        }

        public Task CloseModal()
        {
            IsVisible = false;
            ChildContent = null;

            return InvokeAsync(() =>
            {
                StateHasChanged();
            });
        }
    }
}

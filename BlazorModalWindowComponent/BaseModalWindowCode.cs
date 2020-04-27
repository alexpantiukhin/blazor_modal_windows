using Microsoft.AspNetCore.Components;

using System.Threading.Tasks;

namespace BlazorModalWindowComponent
{
    public class BaseModalWindowCode : ComponentBase
    {
        [Parameter]
        public string ContainerClass { get; set; }
        protected bool IsVisible { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

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

using Microsoft.AspNetCore.Components;

using System.Threading.Tasks;

namespace BlazorModalWindowComponent
{
    public class BaseWindowWithContainerCode<TService, TModel> : BaseModalWindowCode
        where TService : AbstractDerivedModalWindowService<TModel>
    {
        [Inject]
        public TService _modalService { get; set; }

        [Parameter]
        public TModel Model { get; set; }

        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public bool ShowTitle { get; set; }
        protected override void OnInitialized()
        {
            _modalService.OnShow += ShowModal;
            _modalService.OnClose += CloseModal;
        }

        public Task ShowModal(TModel model, string containerClass)
        {
            Model = model;
            IsVisible = true;
            ContainerClass = containerClass;

            return InvokeAsync(() =>
            {
                StateHasChanged();
            });
        }

        public void Dispose()
        {
            _modalService.OnShow -= ShowModal;
            _modalService.OnClose -= CloseModal;
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (IsVisible == false)
            {
                await _modalService.ClosedCall();
            }
            else
            {
                await _modalService.ShowedCall();
            }
        }


    }
}

using BlazorModalWindowComponent.Interfaces;
using Microsoft.AspNetCore.Components;

using System.Threading.Tasks;

namespace BlazorModalWindowComponent
{
    public class BaseWindowWithContainer<TService, TModel> : BaseModalWindow
        where TService : AbstractDerivedModalWindowService<TModel>
        where TModel : IWindowWithContainerModel
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
                await _modalService.ClosedCall();
            else
                await _modalService.ShowedCall();
        }

        protected override RenderFragment Content(RenderFragment childContent = null)
        {
            RenderFragment a = x =>
            {
                x.OpenComponent<WindowContainer>(0);
                    x.AddAttribute(1, nameof(WindowContainer.OnClose), EventCallback.Factory.Create(this, () => _modalService.Close()));
                    x.AddAttribute(2, nameof(WindowContainer.Title), string.IsNullOrWhiteSpace(Title) ? Texts.DefaultConfirmTitle : Title);
                    x.AddAttribute(3, nameof(WindowContainer.ShowTitle), ShowTitle);
                    x.AddAttribute(4, nameof(WindowContainer.ChildContent), childContent ?? ChildContent);
                x.CloseComponent();
            };
            return base.Content(a);
        }
    }
}

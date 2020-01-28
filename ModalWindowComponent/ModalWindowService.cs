using Microsoft.AspNetCore.Components;

using System;
using System.Threading.Tasks;

namespace ModalWindowComponent
{
    public class ModalWindowService : AbstractDerivedModalWindowService
    {
        public event Func<RenderFragment, Task> OnShow;

        /// <summary>
        /// В типе контента необходимо поле Model для получения модели
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="contentType"></param>
        /// <param name="model">Модель данных</param>
        /// <param name="events">Модель событий</param>
        public Task Show<TModel, TEventModel>(Type contentType, TModel model, TEventModel events)
        {
            if (contentType.BaseType != typeof(ComponentBase))
            {
                throw new ArgumentException($"{contentType.FullName} must be a Blazor Component");
            }

            var content = new RenderFragment(x => { x.OpenComponent(1, contentType); x.AddAttribute(1, "Model", model); x.AddAttribute(2, "EventModel", events); x.CloseComponent(); });

            return Show(content);
        }

        //public Task Show<TModel>(Type contentType, TModel model)
        //{
        //    if (contentType.BaseType != typeof(ComponentBase))
        //    {
        //        throw new ArgumentException($"{contentType.FullName} must be a Blazor Component");
        //    }

        //    var content = new RenderFragment(x => { x.OpenComponent(1, contentType); x.AddAttribute(2, "Model", model); x.CloseComponent(); });

        //    return Show(content);
        //}

        public Task Show(RenderFragment content)
        {
            return OnShow?.Invoke(content);
        }
    }
}

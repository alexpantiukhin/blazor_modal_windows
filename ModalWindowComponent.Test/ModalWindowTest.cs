using CommonTest;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Testing;

using Xunit;

namespace ModalWindowComponent.Test
{
    public class ModalWindowTest
    {
        TestHost host = new TestHost();
        ModalWindowService _modalService = new ModalWindowService();
        static string testContentString = "TestContent";

        RenderFragment testContent = (builder) =>
        {
            builder.AddContent(1, testContentString);
        };

        public ModalWindowTest()
        {
            host.AddService(_modalService);
        }

        [Fact]
        public void WithoutContentBeforShow_CssClassContainer()
        {
            var component = Common.GetTestComponent<ModalWindow>(host);

            var container = component.Find("div.bm-container");
            var activeContainer = component.Find("div.bm-container.bm-active");

            Assert.NotNull(container);
            Assert.Null(activeContainer);

        }

        [Fact]
        public async void WithContentShow_CssClassContainerActive()
        {
            var component = Common.GetTestComponent<ModalWindow>(host, null, null, true);

            _modalService.OnShow += async (x) =>
            {
                var activeContainer = component.Find("div.bm-container.bm-active");

                var markup = component.GetMarkup();

                Assert.NotNull(activeContainer);
                Assert.Contains(testContentString, activeContainer.InnerText);

            };

            _modalService.OnClose += async () =>
            {
                var activeContainer = component.Find("div.bm-container.bm-active");

                Assert.Null(activeContainer);
            };

            await _modalService.Show(testContent);

            await _modalService.Close();
        }
    }
}

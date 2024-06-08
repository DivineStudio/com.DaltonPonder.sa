using Microsoft.JSInterop;

namespace com.DaltonPonder.sa.Services
{
    public class JSInteropService : IDisposable
    {
        private readonly IJSRuntime _jsRuntime;

        public JSInteropService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async ValueTask<string> GetCultureFromBrowser()
        {
            return await _jsRuntime.InvokeAsync<string>("getCultureFromBrowser");
        }

        public async ValueTask SetHtmlLangAttribute(string culture)
        {
            await _jsRuntime.InvokeVoidAsync("setHtmlLangAttribute", culture);
        }

        public async ValueTask SetUpSkipToAboutMe()
        {
            await _jsRuntime.InvokeVoidAsync("setUpSkipToAboutMe");
        }

        public void Dispose()
        {
        }
    }
}

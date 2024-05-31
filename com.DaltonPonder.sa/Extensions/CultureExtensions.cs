using Blazored.LocalStorage;
using com.DaltonPonder.sa.Constants;
using com.DaltonPonder.sa.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;
using System.Globalization;

namespace com.DaltonPonder.sa.Extensions
{
    public static class CultureExtensions
    {
        public async static Task SetDefaultUICulture(this WebAssemblyHost host, IJSRuntime jsRuntime)
        {
            var localStorage = host.Services.GetRequiredService<ILocalStorageService>();

            var result = await localStorage.GetItemAsync<string>(CultureConstants.CurrentCultureKey);
            CultureInfo culture;
            if (result != null && result == CultureConstants.EnglishLanguageKey || result == CultureConstants.SpanishLanguageKey)
            {
                culture = new CultureInfo(result);
            }
            else
            {
                //var browserCulture = string.Empty;
                CultureInfo browserCulture;

                using (var js = new JSInteropService(jsRuntime)) {
                    var cultureString = await js.GetCultureFromBrowser();
                    if (cultureString != null)
                    {
                        browserCulture = new CultureInfo(cultureString);
                    }
                    else
                    {
                        browserCulture = new CultureInfo(CultureConstants.EnglishLanguageKey);
                    }
                }

                if (browserCulture.TwoLetterISOLanguageName == CultureConstants.SpanishLanguageKey)
                {
                    culture = new CultureInfo(CultureConstants.SpanishLanguageKey);
                    await localStorage.SetItemAsStringAsync(CultureConstants.CurrentCultureKey, CultureConstants.SpanishLanguageKey);
                }
                else
                {
                    culture = new CultureInfo(CultureConstants.EnglishLanguageKey);
                    await localStorage.SetItemAsStringAsync(CultureConstants.CurrentCultureKey, CultureConstants.EnglishLanguageKey);
                }
            }

            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
        }
    }
}

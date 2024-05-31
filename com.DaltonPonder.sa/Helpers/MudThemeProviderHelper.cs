using MudBlazor;

namespace com.DaltonPonder.sa.Helpers
{
    public static class MudThemeProviderHelper
    {
        public static MudTheme GetMudTheme() => new MudTheme()
        {
            Palette = new Palette()
            {
                White = "#F5F5F5",
                Black = "#000000",
                TextPrimary = "#000000",
                Background = "#F5F5F5",
                Primary = "#952323",
                PrimaryContrastText = "#F5F5F5",
                PrimaryLighten = "#A12525",
                PrimaryDarken = "#7A1C1C",
                Secondary = "#F2E8C6",
                SecondaryContrastText = "#000000",
                SecondaryLighten = "#FFF4D1",
                SecondaryDarken = "#D9D0B2",
                Tertiary = "#F5F5F5",
                TertiaryContrastText = "#000000",
                TertiaryLighten = "#FFFFFF",
                TertiaryDarken = "#DBDBDB",
                AppbarBackground = "#952323",
                AppbarText = "#F5F5F5",
                Divider = "#952323",
                DividerLight = "#F2E8C6",
            },
            Typography = new Typography()
            {
                Default = new Default()
                {
                    FontSize = "16px",
                },
                H1 = new H1()
                {
                    FontFamily = new string[4] { "RobotoSlab", "Helvetica", "Arial", "sans-serif" },
                    FontSize = "2rem",
                    FontWeight = 500,
                    LineHeight = 2.3,
                },
                H2 = new H2()
                {
                    FontSize = "1.5rem",
                    FontWeight = 500,
                    LineHeight = 1.8,
                },
                H3 = new H3()
                {
                    FontSize = "1.3rem",
                    FontWeight = 500,
                    LineHeight = 1.6,
                },
                Body1 = new Body1()
                {
                    FontSize = "1.125rem",
                    FontWeight = 400,
                    LineHeight = 1.5,
                },
                Body2 = new Body2()
                {
                    FontSize = "1rem",
                    FontWeight = 400,
                    LineHeight = 1.5,
                },
            }
        };
    }
}

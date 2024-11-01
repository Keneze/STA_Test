using Microsoft.Playwright;

namespace STA_Test.Drivers
{
    public class PlaywrightDriver
    {
        private static IPlaywright _playwright;
        private static IBrowser _browser;

        public static async Task<IPage> GetPage()
        {
            if (_playwright == null)
            {
                _playwright = await Playwright.CreateAsync();
                _browser = await _playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
                {
                    Headless = false, // Set to true for headless mode in CI/CD pipelines
                    SlowMo = 50 // Optional: Add a delay between actions for better visibility during debugging
                });
            }

            var context = await _browser.NewContextAsync(new BrowserNewContextOptions
            {
                ViewportSize = new ViewportSize { Width = 1280, Height = 720 },
                IgnoreHTTPSErrors = true
            });

            return await context.NewPageAsync();
        }

        public static async Task CloseAsync()
        {
            if (_browser != null)
            {
                await _browser.CloseAsync();
                _playwright.Dispose();
                _playwright = null;
            }
        }
    }
}

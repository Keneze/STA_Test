
using TechTalk.SpecFlow;
using Microsoft.Playwright;
using STA_Test.Drivers;
using System.Threading.Tasks;

namespace STA_Test.Hooks
{
    [Binding]
    public class Hooks
    {

        public Hooks(ScenarioContext scenarioContext)
        {
            BasePage._scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public async Task BeforeScenario()
        {
            var page = await PlaywrightDriver.GetPage();
            BasePage._scenarioContext["Page"] = page;
            BasePage._page = page;

        }

        [AfterScenario]
        public async Task AfterScenario()
        {
            await PlaywrightDriver.CloseAsync();
        }
    }
}
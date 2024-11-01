using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace STA_Test
{
    public class BasePage
    {
        public static IPage _page;
        public static ScenarioContext _scenarioContext = null;
    }
}

//namespace STA_CodingChallenge.Tests.PageObjects
using Microsoft.Playwright;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace STA_Test.PageObjects
{
    public class JourneyPlannerPage:BasePage
    {

        // Locate "From" and "To" fields and enter locations using autocomplete
        public ILocator fromField = _page.Locator("#InputFrom");
        public ILocator toField = _page.Locator("#InputTo");
        public ILocator suggestionList = _page.Locator(".tt-suggestion");
        public ILocator playMyJourneyButton = _page.Locator("#plan-journey-button");
        public ILocator walkingTime =  _page.Locator(".journey-box.walking .journey-info");
        public ILocator cyclingTime = _page.Locator(".journey-box.cycling .journey-info");

        public ILocator fieldErrorMessage = _page.Locator("li.field-validation-error");
        public ILocator editPreferences = _page.Locator(".edit-preferences button");

        public ILocator fromInputErrorMessage = _page.Locator("span[id='InputFrom-error']");
        public ILocator toInputErrorMessage = _page.Locator("span[id='InputTo-error']");

        public ILocator leastWalkingTimes = _page.Locator(".journey-time.no-map");
        public ILocator viewDetailsButton = _page.Locator(".show-detailed-results:has-text('View details')");
        public ILocator hideDetailsButton = _page.Locator(".show-detailed-results:has-text('Hide details')");



        public async Task NavigateToHomePage()
        {
            await _page.GotoAsync("https://tfl.gov.uk/plan-a-journey");
            //await _page.GetByText("Accept all cookies").ClickAsync();
            await _page.Locator("button:has-text('Accept all cookies')").HoverAsync();
            await _page.WaitForTimeoutAsync(1000);
            await _page.Locator("button:has-text('Accept all cookies')").ClickAsync();

        }

        public async Task PlanJourney(string from, string to)
        {


            if (!string.IsNullOrEmpty(from))
            {
                await this.fromField.FillAsync(from);
                await this.suggestionList.First.ClickAsync();
            }

            if (!string.IsNullOrEmpty(to))
            {
                await this.toField.FillAsync(to);
                await this.suggestionList.First.ClickAsync();
            }

            // Click "Plan my journey" button
            await this.playMyJourneyButton.ClickAsync();
        }

        public async Task InvalidPlanJourney(string from, string to)
        {
            // Locate "From" and "To" fields and enter locations using autocomplete
            var fromField = _page.Locator("#InputFrom");
            var toField = _page.Locator("#InputTo");


            // Click "Plan my journey" button
            await this.playMyJourneyButton.ClickAsync();
        }

        public async Task<Dictionary<string, string>> GetJourneyTimes()
        {
            var times = new Dictionary<string, string>();

            // Extract journey times for walking and cycling journey-box walking
            
            if (!string.IsNullOrEmpty(await this.walkingTime.TextContentAsync()))
                times.Add("walking", await this.walkingTime.TextContentAsync());

            if (!string.IsNullOrEmpty(await this.cyclingTime.TextContentAsync()))
                times.Add("cycling", await this.cyclingTime.TextContentAsync());
            BasePage._scenarioContext["WalkingTime"] = times["walking"];

            return times;
        }

        public async Task EditPreferences(string preference)
        {
            // Click on "Edit preferences" button
            await this.editPreferences.ClickAsync();

            // Select preference (e.g., "least walking")
            await _page.Locator("label:has-text('Routes with least walking')").ClickAsync();

            // Update the journey
            await _page.Locator(".primary-button").Last.ClickAsync();
        }

        public async Task<string> GetUpdatedJourneyTime()
        {
            return await _page.Locator(".updated-journey-time").TextContentAsync();
        }

        public async Task ClickLink(string linkText)
        {
            await _page.Locator($"text={linkText}").ClickAsync();
        }

        public async Task<string> GetAccessInformation()
        {
            return await _page.Locator(".access-information").TextContentAsync();
        }



        public async Task<string> GetValidationMessage()
        {
            return await _page.Locator(".validation-message").TextContentAsync();
        }
    }
}
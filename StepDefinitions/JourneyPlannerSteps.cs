using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Numerics;
using STA_Test.Hooks;
using STA_Test.PageObjects;
using STA_Test;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace STA_Test.StepDefinitions
{
    [Binding]
    public class JourneyPlannerSteps
    {
        private readonly PageObjects.JourneyPlannerPage _journeyPlannerPage;

        public JourneyPlannerSteps()
        {
            _journeyPlannerPage = new PageObjects.JourneyPlannerPage();
        }

        [Given(@"I navigate to the TfL website")]
        public async Task GivenINavigateToTheTFLWebsite()
        {
            await _journeyPlannerPage.NavigateToHomePage();
           // await BasePage._page.WaitForTimeoutAsync(10000);
        }

        [When(@"I plan a journey from ""(.*)"" to ""(.*)""")]

        public async Task WhenIPlanAJourneyFromTo(string from, string to)
        {
            await _journeyPlannerPage.PlanJourney(from, to);
        }

        [Then(@"I should see journey times for walking and cycling")]
        public async Task ThenIShouldSeeJourneyTimesForWalkingAndCycling()
        {
            var journeyTimes = await _journeyPlannerPage.GetJourneyTimes();
            Assert.IsNotNull(journeyTimes, "Journey times were not found.");
            Assert.IsTrue(journeyTimes.ContainsKey("walking"), "Walking time is missing.");
            Assert.IsTrue(journeyTimes.ContainsKey("cycling"), "Cycling time is missing.");
        }

        [When(@"I edit preferences to select the route with the least walking")]
        public async Task WhenIEditPreferencesToSelectTheRouteWithTheLeastWalking()
        {
            await _journeyPlannerPage.EditPreferences("least walking");
        }

        [Then(@"the journey time should be updated")]
        public async Task ThenTheJourneyTimeShouldBeUpdated()
        {
      
            var actualTime =Convert.ToInt32(BasePage._scenarioContext["WalkingTime"].ToString().Replace("mins", "").Trim());
          Console.WriteLine("Actual Time"+actualTime);
            var updatedTime =Convert.ToInt32(((await _journeyPlannerPage.leastWalkingTimes.First.TextContentAsync()).ToString().Replace("\\n","").Trim().Split(" "))[2].Replace("mins", "").Trim());
           Console.WriteLine("Updated Time"+updatedTime);
            Assert.AreNotEqual(actualTime, updatedTime);
        }

        [When(@"I click on View Details")]
        public async Task WhenIClickOn()
        {
            await _journeyPlannerPage.viewDetailsButton.First.ClickAsync();
        }

        [Then(@"I should see complete access information for Covent Garden Underground Station")]
        public async Task ThenIShouldSeeCompleteAccessInformationForCoventGardenUndergroundStation()
        {
            Assert.True(await _journeyPlannerPage.hideDetailsButton.IsVisibleAsync());
        }

        [When(@"I try to plan a journey with an invalid location")]
        public async Task WhenITryToPlanAJourneyWithAnInvalidLocation()
        {

            await _journeyPlannerPage.fromField.FillAsync("0289");
            await _journeyPlannerPage.toField.FillAsync("130");
            await _journeyPlannerPage.playMyJourneyButton.ClickAsync();


        }

        [Then(@"I should see an error message")]
        public async Task ThenIShouldSeeAnErrorMessage()
        {
            Assert.IsNotNull(await _journeyPlannerPage.fieldErrorMessage.TextContentAsync(), "Error message was not displayed.");
        }

        [When(@"I attempt to plan a journey without entering any locations")]
        public async Task WhenIAttemptToPlanAJourneyWithoutEnteringAnyLocations()
        {
            await _journeyPlannerPage.playMyJourneyButton.ClickAsync();
        }

        [Then(@"I should see a validation message")]
        public async Task ThenIShouldSeeAValidationMessage()
        {
            Assert.IsNotNull(await _journeyPlannerPage.fromInputErrorMessage.TextContentAsync(), "The From field is required.");
            Assert.IsNotNull(await _journeyPlannerPage.toInputErrorMessage.TextContentAsync(), "The To field is required.");

        }
    }
}
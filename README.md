# STA_Test

## A file to explain the project, how to set up the environment, and run the tests.


This is a test automation framework for testing the "Journey Planner" widget on the TfL website using Playwright and SpecFlow in C#.

## Prerequisites

- Visual Studio 2022
- .NET SDK (latest version)
- SpecFlow Extension for Visual Studio
  
## Setup Instructions

Clone the repository to your local machine:

- git clone https://github.com/Keneze/STA_Test.git

## Open the project in Visual Studio.

## Install the necessary NuGet packages:

- SpecFlow
- SpecFlow.NUnit
- Microsoft.Playwright
- SpecFlow.Plus.LivingDocPlugin
- 
## Install Playwright browsers by running the following command in the Package Manager

console:
- playwright install

## Running the Tests

### Option 1: Using Visual Studio
  
- Open Test Explorer in Visual Studio.
- Build the project to restore dependencies.
- Run all tests or individual tests from Test Explorer.
(On your Visual Studio navigate to Test --> Test Explorer --> Click 'Run' to run all tests)

### Option 2: Using Command Line

- Run the following command to execute the tests:
  
dotnet test

  
## Project Structure

- Features/ - Contains SpecFlow feature files written in Gherkin.
- StepDefinitions/ - Contains step definition files that implement the test steps.
- PageObjects/ - Contains page object model files that encapsulate web element interactions.
- Drivers/ - Contains Playwright driver configuration.
- Hooks/ - Contains setup and teardown hooks for tests.
- README.md - Documentation for the project.

## Test Scenarios Implemented

1. Plan a Valid Journey: Test that a journey can be successfully planned from "Leicester Square Underground Station" to "Covent Garden Underground Station".
2. Edit Journey Preferences: Change the journey preferences to select the route with the least walking.
3. View Journey Details: Verify access information for Covent Garden Underground Station.
4. Plan an Invalid Journey: Verify that an error message is displayed when planning a journey with invalid locations.
5. Plan a Journey Without Locations: Ensure that a validation message is shown when no locations are provided.

## Development Decisions

- Playwright was selected for its speed and modern web automation capabilities.
- The Page Object Model was implemented to keep web interactions separate from the test logic.
- Gherkin syntax with SpecFlow allows writing tests in a human-readable format, suitable for Behavior-Driven Development (BDD).

## Future Enhancements

- Parallel Execution: Implement parallel test execution to speed up the test runs.
- CI/CD Integration: Integrate with a CI/CD pipeline to automate test execution on pull requests.
- Enhanced Reporting: Add more comprehensive test reports, including screenshots and detailed logs.
- Non-Functional Testing: Consider adding performance tests and accessibility checks.

## Troubleshooting

If you encounter issues with running the tests, try the following:

- Verify that Playwright is installed: Run playwright install again if necessary.
- Make sure you have the latest .NET SDK: Update the .NET SDK to ensure compatibility.
- Check browser drivers and settings: Make sure the appropriate browser drivers are installed and configured.

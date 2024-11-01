# A file to explain the project, how to set up the environment, and run the tests.

# STA Automation Framework

This is a test automation framework for testing the "Journey Planner" widget on the TfL website using Playwright and SpecFlow in C#.

## Prerequisites

- Visual Studio 2022
- .NET SDK (latest version)
- SpecFlow Extension for Visual Studio

## Setup Instructions

1. Clone the repository to your local machine:

   git clone <repository-url>

# Open the project in Visual Studio.

# Install the necessary NuGet packages:

- SpecFlow
- SpecFlow.NUnit
- Microsoft.Playwright
- SpecFlow.Plus.LivingDocPlugin
  
# Install Playwright browsers by running the following command in the Package Manager
## console:
- playwright install

# Project Structure
- Features/ - Contains SpecFlow feature files written in Gherkin.
- StepDefinitions/ - Contains step definition files that implement the test steps.
- PageObjects/ - Contains page object model files that encapsulate web element interactions.
- Drivers/ - Contains Playwright driver configuration.
- Hooks/ - Contains setup and teardown hooks for tests.
- README.md - Documentation for the project.

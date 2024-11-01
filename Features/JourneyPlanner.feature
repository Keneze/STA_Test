Feature: Journey Planner
  As a user of the TfL website,
  I want to be able to plan a journey using the "Plan a journey" widget,
  So that I can find the best route to my destination.

  Scenario: Plan a valid journey
    Given I navigate to the TfL website
    When I plan a journey from "Leicester Square Underground Station" to "Covent Garden Underground Station"
    Then I should see journey times for walking and cycling

  Scenario: Edit journey preferences
    Given I navigate to the TfL website
    When I plan a journey from "Leicester Square Underground Station" to "Covent Garden Underground Station"
    Then I should see journey times for walking and cycling
    When I edit preferences to select the route with the least walking
    Then the journey time should be updated

  Scenario: View details of the journey
    Given I navigate to the TfL website
    When I plan a journey from "Leicester Square Underground Station" to "Covent Garden Underground Station"
      When I edit preferences to select the route with the least walking
   When I click on View Details
    Then I should see complete access information for Covent Garden Underground Station

  Scenario: Plan an invalid journey
    Given I navigate to the TfL website
    When I try to plan a journey with an invalid location
    Then I should see an error message

  Scenario: Plan a journey without entering locations
    Given I navigate to the TfL website
    When I attempt to plan a journey without entering any locations
    Then I should see a validation message


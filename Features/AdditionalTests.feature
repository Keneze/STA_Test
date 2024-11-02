## Scenario: Verify screen reader compatibility for the journey widget
  Given I navigate to the TfL website
  When I use a screen reader to read the "Plan a journey" widget
  Then I should hear all labels, instructions, and results clearly

## Scenario: Verify the "Plan a journey" widget functionality on Chrome browser
  Given I open the TfL website in Chrome
  When I plan a journey from "Leicester Square Underground Station" to "Covent Garden Underground Station"
  Then the journey should be planned successfully

# 1. Scenario: Verify screen reader compatibility for the journey widget
#  Given I navigate to the TfL website
#  When I use a screen reader to read the "Plan a journey" widget
#  Then I should hear all labels, instructions, and results clearly

# 2. Scenario: Verify the "Plan a journey" widget functionality on Chrome browser
#  Given I open the TfL website in Chrome
#  When I plan a journey from "Leicester Square Underground Station" to "Covent Garden Underground Station" # Then the journey should be planned successfully

# 3. Scenario: Verify the "Plan a journey" widget functionality on Firefox browser
#  Given I open the TfL website in Firefox
#  When I plan a journey from "Leicester Square Underground Station" to "Covent Garden Underground Station"
#  Then the journey should be planned successfully
  
# 4. Scenario: Verify the "Plan a journey" widget functionality on Safari browser
#  Given I open the TfL website in Safari
#  When I plan a journey from "Leicester Square Underground Station" to "Covent Garden Underground Station"
#  Then the journey should be planned successfully

# 5. Scenario: Verify that the "Plan a journey" widget supports Spanish language
#  Given I set the TfL website language to Spanish
#  When I use the "Plan a journey" widget
#  Then the widget should display labels and instructions in Spanish
  
# 6. Scenario: Verify that the "Plan a journey" widget supports French language
#  Given I set the TfL website language to French
#  When I use the "Plan a journey" widget
#  Then the widget should display labels and instructions in French

# 7. Scenario: Verify validation message for missing 'From' location
#  Given I navigate to the TfL website
#  When I leave the 'From' field empty and fill in the 'To' field
#  And I click "Plan my journey"
#  Then I should see a validation message for the missing 'From' location
  
# 8. Scenario: Verify validation message for missing 'To' location
#  Given I navigate to the TfL website
#  When I fill in the 'From' field and leave the 'To' field empty
#  And I click "Plan my journey"
#  Then I should see a validation message for the missing 'To' location

# 9. Scenario: Verify autocomplete suggestions for the 'From' field
#  Given I navigate to the TfL website
#  When I start typing "Leicester"
#  Then I should see autocomplete suggestions related to "Leicester"

# 10. Scenario: Verify autocomplete suggestions for the 'To' field
#  Given I navigate to the TfL website
#  When I start typing "Covent"
#  Then I should see autocomplete suggestions related to "Covent"

# 11. Scenario: Verify navigation of external links from the journey results
#  Given I plan a journey from "Leicester Square Underground Station" to "Covent Garden Underground Station"
#  When I click on an external link in the results
#  Then I should be navigated to the appropriate external page
  
# 12.Scenario: Verify selecting cycling route in journey preferences
#  Given I plan a journey from "Leicester Square Underground Station" to "Covent Garden Underground Station"
#  When I choose the cycling option in journey preferences
#  Then the journey details should display cycling-specific information

# 13. Scenario: Verify journey preferences for accessibility options
#  Given I plan a journey from "Leicester Square Underground Station" to "Covent Garden Underground Station"
#  When I select the "Step-free access" option in preferences
#  Then the results should show routes that are step-free

# 14. Scenario: Verify the functionality of the "Clear" button
#  Given I have entered values in the 'From' and 'To' fields
#  When I click the "Clear" button
# Then both fields should be cleared
  
# 15. Scenario: Verify the handling of invalid characters in input fields
#  Given I navigate to the TfL website
#  When I enter "!!@@##" in the 'From' and 'To' fields
#  And I click "Plan my journey"
#  Then I should see an appropriate error message

# 16. Scenario: Verify that journey time is displayed after planning
#  Given I plan a valid journey
#  When the results are shown
#  Then I should see the total journey time displayed

# 17. Scenario: Verify that multiple routes are displayed in the results
#  Given I plan a journey from "Leicester Square Underground Station" to "Covent Garden Underground Station"
#  When the results are shown
#  Then I should see more than one route option displayed

# 18. Scenario: Verify map integration in the journey results
#  Given I plan a journey from "Leicester Square Underground Station" to "Covent Garden Underground Station"
#  When the results are shown
#  Then I should see a map showing the journey route

# 19. Scenario: Verify that the "Plan a journey" page loads within acceptable time
#  Given I navigate to the TfL website
#  When the page loads
#  Then it should load within 3 seconds
  
# 20. Scenario: Verify response time when planning a journey
#  Given I navigate to the TfL website
#  When I submit a journey plan request
#  Then the results should be displayed within 2 seconds

# 21 Scenario: Verify input sanitization in the 'From' and 'To' fields
#  Given I navigate to the TfL website
#  When I enter potentially malicious scripts in the input fields
#  And I click "Plan my journey"
#  Then the input should be sanitized and no scripts should be executed

# 22. Scenario: Verify protection against XSS attacks in input fields
#  Given I navigate to the TfL website
#  When I enter a script tag in the 'From' field
#  And I click "Plan my journey"
#  Then no XSS attack should be executed

# 23. Scenario: Verify error handling for network failure during journey planning
#  Given I navigate to the TfL website
# When there is a network failure while planning a journey
# Then I should see an appropriate error message and retry option

# 24. Scenario: Verify system behavior under a high number of concurrent requests
#  Given the TfL website receives 1000 journey plan requests at the same time
#  When the system processes the requests
#  Then the system should handle the load without crashing

# 25. Scenario: Verify keyboard navigation for the "Plan a journey" widget
#  Given I navigate to the TfL website
#  When I use the keyboard to navigate and operate the widget
#  Then I should be able to complete the journey planning without using a mouse







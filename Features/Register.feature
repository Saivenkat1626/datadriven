Feature:Register Page

Testing The register Page Fields
Background: 
Given Open the url
And  Click on Register

@Register
  Scenario: Successful user registration
    Given the user is on the registration page
    When the user enters valid registration details
    And clicks on the submit button
    Then the user should be successfully registered

  


	
	

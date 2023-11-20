Feature: Login page

A short summary of the feature
Background: 
Given open the url

@Login
Scenario:Login with valid details
	Given Enter the valid details
	When Click Login
	Then Verify that User Sucessfully Navigate My Account Page

@Loginwithexcel
Scenario Outline: signin_functionality
Given entered "<username>" and "<password>" present at signin page
When Click Login
Then Verify that User Sucessfully Navigate My Account Page
@
Examples: 
| username        | password |
| sai3@gmail.com | Saivenkat |


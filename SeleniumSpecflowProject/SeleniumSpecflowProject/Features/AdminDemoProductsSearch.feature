Feature: AdminDemoProductSearch
Description

Scenario: loging test
Given User is Logged in to the website
When User navigate to the Products page under Catalogue
And User chooses Show 7 items
Then the following 7 items are displayed
|items|
|Build your own computer|
|Digital Storm VANQUISH 3 Custom Performance PC|
|Lenovo IdeaCentre 600 All-in-One PC|
|Apple MacBook Pro 13-inch|
|Asus N551JK-XO076H Laptop|
|Samsung Series 9 NP900X4C Premium Ultrabook|
|HP Spectre XT Pro UltraBook|

[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/iMuJtRnH)
# GroupProject

README.md: The goal of this program is to create a car inventory system where users can find the perfect vehicle for them. For instance, different cars will be categorized based on features such as brand, year, mileage, type, and more. This will enable users to view, sort, and manage vehicles based on their preferences.The system is meant to be intuitive and user-friendly, allowing for easy input, modification, and retrieval of car data. 
The goal we have in mind is to create a model that separates the user interface from a client perspective and a dealership/seller perspective. This means that from a client perspective, the UI/UX will be very intuitive and will save time when filtering different vehicles. On the other hand, the dealership perspective will kind of act as our back-end. The way we plan to achieve this is by using VB.Net for our front-end and MySQL for our back-end. 
For our back-end, MySQL will be our database management system of choice. MySQL is the perfect choice for this, as a car inventory system involves a large dataset. Our data set contains information about vehicles such as their name, MPG, weight, displacement, year, horsepower, and country of origin. Based on these characteristics, users will be able to find the perfect car tailored to their preferences. 
The front-end of our project will be a VB form. This will allow us to create a familiar UI that is intuitive for users. In the form, the users will be able to choose from multiple drop-down options, each representing a certain characteristic of the vehicle. Based on these options, the user will be able to view a list of vehicles that are more suited to their preferences. For example, if a user has a budget of $30,000 vs. $100,000, the user with the $30,000 will be presented with much more limited options. After a user inputs all their preferences, the datagrid will update, showcasing the vehicles that are tailored to their preferences. There will also be a clear filter button at the bottom, which will reset the data grid back to its original state after the user is done searching for their desired vehicle. We will use ADO.net to connect the two.
In order to make the user experience as streamlined and straightforward as possible, input validation checks have been added throughout the code to ensure that there aren’t any issues on the side of the user. For example, when searching for a specific brand, the user cannot input anything null, and their input will not be case-sensitive.
In summary, the program aims to streamline the process of finding and managing cars in an inventory, catering to both clients seeking vehicles and dealerships managing their collections. The combination of VBA for an accessible front-end and MySQL for a powerful back-end ensures a balanced approach between ease of use and technical capability.

BUGS
- SQL connection may have some issues depending on users.
- Filtering may have some issues if certain options are left blank
- Need to fix user log in and optimize it

To-Do
- Potentially create a second VB form for user login. (dealership perspective and user perspective maybe?)
- Refactor front-end for better useabiity
- When user clicks clear filter button, it will clear user options along with the the datagrid instead of just clearing the datagrid
- Potentially add data visualtion (graph or a chart) in the empty space which shows remaining amount of vehicles in stock given the filters.

NOTES:
- Must have the nuget SQL extension on visual studio
- Users have full admin permissions of the sql databse (can be changed in the future)
- Connection via ADO.net

User Stories:

User Story: Search Vehicle
 As a user I want to be able to search for a vehicle based on categories such as MPG, horsepower, price, and brand. By pressing search, the user will be able to filter out all vehicles that do not match the user's preferences.

User Story: View Vehicles
 	As a user, after clicking the search button, I want to be able to see an updated DataGrid which displays all the vehicles that match my preference.

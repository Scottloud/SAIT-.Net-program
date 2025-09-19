# FinalOOProject

This is group 6's final project for CPRG211-C

## Purpose:
Our application is designed to help library administrators in running and operating an active library.

Our app has 4 main pages:
1. Search - This allows a user to look up details about books current in the libraries collection. It does this by
taking the lower case of the entered value and checking to see if any book objects in the system match that value
2. Collection Management - This allows a user to lend and return books to the library, as well as add and update existing books. Note
that books currently on loan to a customer cannot be updated.
3. Customer Record - This is a record of all current members of the library. It allows for customers to be added and updated. The main
screen shows an overviews of a customers details, which can be expanded with the detail button.
4. Staff Directory - This holds all the information for all employees of the library. With add, edit, and deletion functions.

## Features:
This app makes use of the following OOP principles:
1. Classes - All data objects are creating using a class model, with attributes for the different column values. This was repeated 
for the service classes.
2. Inheritance - Database objects inherit some default variables and functions from a 'DatabaseEntry' parent class.
3. Encapsulation - Page functions are handled through service objects so the function operation is less visible to the user on the 
page.
4. Interface - Service objects call a 'IService' interface which holds reserved function names to be implemented
5. Data Validation - User entered data is checked through functions contained in a separate data validator class to ensure that no
overflows or data corruption occurs.
6. Exception handling - During data validation try-catch blocks are used to throw exceptions if check conditions are not met. These 
data in the exception message is then used to display an error message to the user on screen.
7. UI - The application makes use of a ui to allow users to interact with the system with a mouse and keyboard, rather than a commend line. 
The colours chosen match the SAIT branding guide. Blue is used for general buttons, while purple is reserved for editing, and red
is reserved for data deletion functions.

## Demo Information:
To help demo the use of the application, a button has been added to the index screen to populate the database with some sample data. 
Please note that the sql file called by this function will clear all data in the tables if they exist before inserting the sample data.
 This means that any data entered into the tables before the button is pushed will be removed.


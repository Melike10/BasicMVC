
# Customer and Order Management System - Basic MVC
## Overview
This project is a basic MVC application developed with ASP.NET Core, demonstrating a simple customer and order management system. It displays customer information along with their respective orders on a single page, using a view model to pass data from the controller to the view.

## Features
Displays customer details such as ID, first name, last name, and email.

Lists all orders related to a customer, showing the order ID, product name, price, quantity, and total cost for each product.

Implements MVC (Model-View-Controller) architecture.

Uses a view model to encapsulate customer and order data.

## Technologies Used
ASP.NET Core MVC: The project is built using the Model-View-Controller design pattern.

C#: The primary programming language used for logic and business rules.
Razor Pages: The view layer utilizes Razor syntax to dynamically display the data.
HTML: The structure of the view is implemented with standard HTML for web presentation.
## Project Structure
### *Models*:

Customer: Represents the customer with properties like Id, FirstName, LastName, and Email.
Order: Represents the order with properties like Id, ProductName, Price, and Quantity.
CustomerOrderViewModel: A view model that encapsulates both Customer and Order lists, allowing both data sets to be passed to the view.
### *Controllers*:

OrdersController: Contains the logic for preparing and passing the CustomerOrderViewModel to the view.
### *Views*:

Index.cshtml: Displays the customer and order details in a tabular format, using the CustomerOrderViewModel.
## Usage
Clone or download the project to your local machine.
Open the project in your preferred IDE (e.g., Visual Studio).
Build and run the project.
Navigate to the /Orders/Index URL to see the customer and order details.
## Example
The view displays customer and order details like the following:

Customer Information:

ID: 1
First Name: John
Last Name: Doe
Email: john.doe@example.com
Order Information:

Order 1: Product 1, Price: 100, Quantity: 2, Total: 200
Order 2: Product 2, Price: 200, Quantity: 1, Total: 200

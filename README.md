# Inventory Management System

#### Created on VS Code Community 2022
#### Language used: C#
#### .Net Version: .NET Framework 9

### Task
Throughout your career in software design and development, you will be asked to create applications with various features and functionality based on business requirements. When a new system is developed, the process typically begins with a business analyst gathering and writing the business requirements with the assistance of subject matter experts from the business. A system analyst then works with several application team members and others to formulate a solution based on the requirements. As a developer, you would then create a design document from the solution and finally develop the system based on your design document.

For this assessment, you will create a C# application using the solution statements provided in the requirements section.

### UML Class Diagram
<img width="1287" height="724" alt="image" src="https://github.com/user-attachments/assets/7d59f117-b810-4258-83a7-6200fee502ac" />


### Requirements
I. User Interface

  A. Create a main form showing the following controls:
  
  1. Buttons for "Add," "Modify," "Delete," "Search" for parts and products, and "Exit"   
  2. Lists for parts and products    
  3. Text boxes for searching for parts and products    
  4. Title labels for parts, products, and the application title

  B. Create an "Add Part" form showing the following controls:
  
  1. Radio buttons for "In-House" and "Outsourced" parts    
  2. Buttons for "Save" and "Cancel"   
  3. Text boxes for ID, name, inventory level, price, max and min values, and company name or machine ID    
  4. Labels for ID, name, inventory level, price or cost, max and min values, the form title, and company name or machine ID

  C. Create a "Modify Part" form with fields that populate with data from an existing part showing the following controls:
  
  1. Radio buttons for "In-House" and "Outsourced" parts  
  2. Buttons for "Save" and "Cancel"    
  3. Text boxes for ID, name, inventory level, price, max and min values, and company name or machine ID
  4. Labels for ID, name, inventory level, price, max and min values, the form title, and company name or machine ID

  D. Create an "Add-Product" form showing the following controls:
  
  1. Buttons for "Save," "Cancel," "Add" part, and "Delete" part
  2. Text boxes for ID, name, inventory level, price, and max and min values
  3. Labels for ID, name, inventory level, price, max and min values, and the form title
  4. A grid view for all parts
  5. A grid view for parts associated with the product
  6. A "Search" button and a text field with an associated list for displaying the results of the search

  E. Create a "Modify Product" form with fields that populate with data from an existing product showing the following controls:
  
  1. Buttons for "Save," "Cancel," "Add" part, and "Delete" part
  2. Text boxes for ID, name, inventory level, price, and max and min values
  3. Labels for ID, name, inventory level, price, max and min values, and the "all candidate parts" grid
  4. A grid view for parts associated with the product
  5. A "Search" button and a text box with an associated list for displaying the results of the searc

II. Classes

  F. Create and implement the appropriate classes, methods, and properties as specified in the attached "UML Class Diagram."

  G. Add the following behaviors to the main form using the classes, methods, and properties implemented in part F:
  
  1. Redirect the user to the "Add Part," "Modify Part," "Add Product," or "Modify Product" forms
  2. Delete a selected part or product from the grid view
  3. Search for a part or product and display matching results
  4. Exit the main form

  H. Add the following behaviors to the part forms using the methods provided in the attached "UML Class Diagram":
  
  1. Add the following behaviors to the "Add Part" form:
      • Select "In-House" or "Outsourced"
      • Enter name, inventory level, price, max and min values, and company name or machine ID
      • Save the data and then redirect to the main form
      • Cancel or exit out of this form and go back to the main form
      
  2. Add the following behaviors to the "Modify Part" form:
      • Select "In-House" or "Outsourced"
      • Modify or change data values
      • Save modifications to the data and then redirect to the main form
      • Cancel or exit out of this form and go back to the main form

  I. Add the following behaviors to the product forms using the methods provided in the attached "UML Class Diagram":
  
  1. Add the following behaviors to the "Add Product" form:
      • Enter name, inventory level, price, and max and min values
      • Save the data and then redirect to the main form
      • Associate one or more parts with a product
      • Remove or disassociate a part from a product
      • Cancel or exit out of this form and go back to the main form
      
  2. Add the following behaviors to the "Modify Product" form:
      • Modify or change data values
      • Save modifications to the data and then redirect to the main form
      • Associate one or more parts with a product
      • Remove or disassociate a part from a product
      • Cancel or exit out of this form and go back to the main form
      
  J. Validate the user input to prevent the following four conditions:
  
  1. Non-numeric values in textboxes that expect numeric values
  2. Min from being greater than max; inventory from being outside the min and max bounds
  3. The user deleting a part that is associated with a product
  4. Deleting a part or product without confirming it first

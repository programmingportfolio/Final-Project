# Lucas Porter 20170718 Project Step 3 
 
## MVP Minimal-viable Product - 
 
###User Roles 
 
Manager: 
Create products with name, category, title, description, price, quantity 
Post content on website. 
Have extended view of Customer Service with approve and disapprove suggestions falling out of protocol (Escalated cases only) 
 
User: 
Add products to cart 
Purchase 
subscription permissions upon purchase 
Download and use products 
Manager or contributor approved comments. 
 
 
 
 
### Features and Objects 
 
Shopping Cart 
Add to cart – Adds various objects classified from the main generic cart. 
Checkout – Checkout page components 
Purchase – What happens during purchase and afterwards. 
 
Customer service form – Page that is also backed by application save state. a series of if else scenarios to ensure that information goes to the correct customer service team. 
 
Product form page – Page that is backed by the application save state. As much details of the product as possible, product description, title, extended textual description and small photos, a video showcase. The possible ability for them to pic their video snapshot. 
 
##Full Product - 
 
###Additional Roles, Objects, and Features 
 
User Authentication with ASP.net 
 
Contributor 
Post content on website 
Approve helpful comments from users 
 
Customer Service Representative: 
Access to Customer Service, showing view to “unhandled” cases, limit 5 per rep, in that rep category. 
Ability to handle cases with approved protocols message to and from users. 
 
 
 
##Stretch Product - 
 
###Additional Roles, Objects, and Features 
 
Hosted on Azure in deployment. 
 
Active directory authentication. 
 
Application save state – takes all data binding upon failure and has it saved into SQL database upon application closure and periodically. The ones that are linked are normally forms. 
 
 
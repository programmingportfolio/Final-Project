# Luke Porter 20190812

##Data Types Needed
1. Products - ordinal number, "user id", title, long description, short description, pictures, video, price, quantity available
2. Orders - Date Time Stamp, Order Number Generated, Order Details
3. Order Details - Products foreign key, quantity of each product ordered, total price, User ordered
4. Categories - Products contained, Picture
5. Users - role priviledges, application save state information, User Orders as Purchase History, Product Creation Id

6. User Orders - Order number as Purchase History.
7. User sensitive -  "username", "pass hash", email, phone number.
8. User Content - posts and comments.

##Table Relationships
1. Products primary product id to Order Details Foreign Key Product id
2. Categories primary key category id to Products Foreign Key category id
3. Orders primary order number to Order Details Foreign Key order number
4. Users primary user id to User Orders primary key user id to Order Details as Purchase History page
5. Users user id pk to User sensitive user id foreign pk
6. Users primary key user id to User Content with pk foreign key user id
7. Users Orders primary key user to Orders Details foreign key user.
8. User content primary key user id Users foreign key to Users
9. Users with Order Details as Purchase History Foreign Key User Ordered
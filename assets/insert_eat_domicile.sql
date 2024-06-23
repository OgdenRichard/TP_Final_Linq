-- ADDRESSES
INSERT INTO Adresses (Street,State,Zip,Country,City) 
VALUES ('rue des Crabes','Morbihan','56000','France','Erdeven');
INSERT INTO Adresses (Street,State,Zip,Country,City) 
VALUES ('boulevard du Pastaga','Bouches du Rhône','13006','France','Marseille');
INSERT INTO Adresses (Street,State,Zip,Country,City) 
VALUES ('impasse Toute Crade','Nord','59012','France','Lille');
INSERT INTO Adresses (Street,State,Zip,Country,City) 
VALUES ('rue des Moumoutes','Indre et Loire','37000','France','Tours');
INSERT INTO Adresses (Street,State,Zip,Country,City) 
VALUES ('passage des Clampins','Paris','75006','France','Paris');

-- USERS
INSERT INTO Users(FirstName,LastName,Mail,AdresseId)
VALUES('Jean-Michel','Michel','jim@michel.mi',5);
INSERT INTO Users(FirstName,LastName,Mail,AdresseId)
VALUES('Suzanne','Plume','plumes@gmail.com',1);
INSERT INTO Users(FirstName,LastName,Mail,AdresseId)
VALUES('Éric','Dampierre','edampierre@gmail.com',5);
INSERT INTO Users(FirstName,LastName,Mail,AdresseId)
VALUES('Adèle','Blansec','ablansec@gmail.com',2);
INSERT INTO Users(FirstName,LastName,Mail,AdresseId)
VALUES('John','Doe','jdoe@gmail.com',3);
INSERT INTO Users(FirstName,LastName,Mail,AdresseId)
VALUES('Pierre','Paul-Jack','ppj@gmail.com',4);

-- DOUGH
INSERT INTO Doughs(Name) VALUES('Croustillante');
INSERT INTO Doughs(Name) VALUES('Moelleuse');
INSERT INTO Doughs(Name) VALUES('Feuilletée');
INSERT INTO Doughs(Name) VALUES('Extra épaisse');
INSERT INTO Doughs(Name) VALUES('Super croustillante');

-- PRODUCT
INSERT INTO Product(Name,Price) VALUES ('Pizza Vegan',10);
INSERT INTO Product(Name,Price) VALUES ('Maxi Burger',15);
INSERT INTO Product(Name,Price) VALUES ('Milk Shake',6);
INSERT INTO Product(Name,Price) VALUES ('Pastis',5);
INSERT INTO Product(Name,Price) VALUES ('Pesto pastas',9);

-- DRINK
INSERT INTO Drink(ProductId,Fizzy,Kcal) VALUES(3,0,800);
INSERT INTO Drink(ProductId,Fizzy,Kcal) VALUES(4,0,500);

-- FOOD
INSERT INTO Food(ProductId,Vegetarian) VALUES(1,1);
INSERT INTO Food(ProductId,Vegetarian) VALUES(2,0);
INSERT INTO Food(ProductId,Vegetarian) VALUES(5,1);

-- PASTA
INSERT INTO Pasta(ProductId,Type,Kcal) VALUES(5,2,900);

-- PIZZA
INSERT INTO Pizza(PizzaId,DoughId) VALUES (1,1);

-- BURGER
INSERT INTO Burger(BurgerId) VALUES (2);

-- INGREDIENTS
INSERT INTO Ingredients (Name,Kcal,PizzaId) VALUES ('Sauce tomate bio',200,1);
INSERT INTO Ingredients (Name,Kcal,PizzaId) VALUES ('Poivrons rouges bio',250,1);
INSERT INTO Ingredients (Name,Kcal,PizzaId) VALUES ('Poivrons verts bio',250,1);
INSERT INTO Ingredients (Name,Kcal,PizzaId) VALUES ('Tofu',150,1);
INSERT INTO Ingredients (Name,Kcal,BurgerId) VALUES ('Gros steack',1000,2);
INSERT INTO Ingredients (Name,Kcal,BurgerId) VALUES ('Cheddar',800,2);
INSERT INTO Ingredients (Name,Kcal,BurgerId) VALUES ('Oignons frits',400,2);
INSERT INTO Ingredients (Name,Kcal,BurgerId) VALUES ('Maroilles',1000,2);

-- ORDER

INSERT INTO Orders(OrderDate,DeliveryDate,Status,UserId,DeliveryAddressId) VALUES(GETDATE(),GETDATE(),1,1,5);
INSERT INTO Orders(OrderDate,DeliveryDate,Status,UserId,DeliveryAddressId) VALUES(GETDATE(),GETDATE(),1,2,1);

-- ORDERPRODUCT
INSERT INTO OrderProduct(OrderId,ProductId) VALUES(1,1);
INSERT INTO OrderProduct(OrderId,ProductId) VALUES(1,3);
INSERT INTO OrderProduct(OrderId,ProductId) VALUES(2,2);
INSERT INTO OrderProduct(OrderId,ProductId) VALUES(2,4);




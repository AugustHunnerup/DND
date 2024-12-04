![image](https://github.com/user-attachments/assets/e89b158a-156e-4b2c-91cd-b9a7519feddd)

1)

ORM changes the way we interact with the database. With ORM we no longer write SQL queries for the most part. Instead, We use ORM to interact with the database. For example, instead of writing SELECT * FROM Hotels.

The image below represents a C# class named HotelContext, which is derived from the DbContext class, a core component of Entity Framework Core (an ORM). This class is used to configure and interact with the database in an object-oriented way.

![image](https://github.com/user-attachments/assets/3327d741-5ca1-49de-ac7a-bc6eabf6b51a)

The Booking class below is an example of how Object-Relational Mapping (ORM) operates by assisting between the object-oriented structure of programming languages (like C#) and relational database systems. 

![image](https://github.com/user-attachments/assets/69adf0fd-61f1-482d-bf6b-b610100bbbcf)

The image below shows a C# class named Event, which is a model class used in the application to represent a database table. This class is relevant in an ORM context, such as Entity Framework Core, where it maps to a corresponding table in the database.

![image](https://github.com/user-attachments/assets/9b9a9f33-f945-4fc4-b335-7364c5e14639)

The image shows a C# class named Hotel, which serves as a model for representing a "hotel" entity in the application. This class is used in conjunction with ORM  to map to a database table.

![image](https://github.com/user-attachments/assets/2b6534b0-13e0-439e-bf7f-b37dfce377ce)

The image shows a C# class named User, which serves as a model in the application, and is used in conjunction with ORM framework. The User class represents a "user" entity in the system, encapsulating data and relationships to other entities.

![image](https://github.com/user-attachments/assets/aa261378-71ad-4e0e-8d96-c170e5e80c3f)



2)

We have not used LINQ, but these are the differences between LINQ and traditional SQL. 


LINQ is embedded in the programming language (C#). Traditional SQL is seperate from the programming language.
LINQ are strongly-typed quesries. Traditional SQL quesries are strings. Errors occur at runtime.
LINQ syntax is decorative and object oriented. Tradtional SQL syntax is also decorative but it is not object-oriented.
LINQ is easier to refactor since it is strong typing. Traditional SQL is more prone to errors during changes.

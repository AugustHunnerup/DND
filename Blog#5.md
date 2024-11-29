![image](https://github.com/user-attachments/assets/e89b158a-156e-4b2c-91cd-b9a7519feddd)

1)

We have not used ORM in the project. ORM changes the way we interact with the database. With ORM we no longer write SQL queries for the most part. Instead, We use ORM to interact with the database through entity classes such as Hotel, Booking, User. For example, instead of writing SELECT * FROM Hotels, ORM allow us to use methods such as .ToList() or .Find().


2)

We have not used LINQ, but these are the differences between LINQ and traditional SQL. 


LINQ is embedded in the programming language (C#). Traditional SQL is seperate from the programming language.
LINQ are strongly-typed quesries. Traditional SQL quesries are strings. Errors occur at runtime.
LINQ syntax is decorative and object oriented. Tradtional SQL syntax is also decorative but it is not object-oriented.
LINQ is easier to refactor since it is strong typing. Traditional SQL is more prone to errors during changes.

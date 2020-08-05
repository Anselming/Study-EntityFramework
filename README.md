# Study-EntityFramework
This repository is only one study about EntityFramemwork, organized in different C# Projects.
For that I used Visual Studio 2019 and .NET Framework 4.7

## Exercice 1 - Hello World Application
Considere one database called 'School_1' with one specific table called 'Students'.

![Students Table](https://github.com/Anselming/Study-EntityFramework/blob/master/assets/students-table.png)
![Students Data](https://github.com/Anselming/Study-EntityFramework/blob/master/assets/students-data.png)
![Students Table Structure](https://github.com/Anselming/Study-EntityFramework/blob/master/assets/students-table-structure.png)


## Exercice 2 - Puralizing
If you have a table called 'Students' but the class on code wants to be called as 'Student'. How do you do that with pluralization?

Ok, normally, nothing special needed to be done, but in my case I have some throubles.
What happenning?
First, you need to know my configuration file. I configure EntityFramework > Contexts > Context tag with a specific attribute: disableDatabaseInitialization = true
So, the convention of pluralizing do not work in my case.

![Context Class](https://github.com/Anselming/Study-EntityFramework/blob/master/assets/pluralizing-context-configuration.png)

If I change disableDatabaseInitialization to False it works, but i can create new tables on the database. So, i really do not want to do that on my production stage.
So, I rosolve keep disableDatabaseInitialization as false, but, on my Context Class I put this configuration for avoid initializing database.

![Context Configuration](https://github.com/Anselming/Study-EntityFramework/blob/master/assets/pluralize-context-class.png)

So, thats work without changes the conventions.

## Exercice 3 - Create custom Pluralizing Convention
In this exercicie I've been created a custom convention.
Imigine this situation: You have a lot a of tables with common name patterns. 
You can use your database without needs to mapping any tables or any properties.
Besides that, you can garantee your database is compliant with your name table patterns.

Normally, a lot of people prefere configure the modelCreating virtual method. In this case, you need to do to all your tables.
![Context Configuration](https://github.com/Anselming/Study-EntityFramework/blob/master/assets/custompluralize-modelCreating.png)

For that i've been create a "Strange" convention.
All models name like 'Strange....y' has a table called 'Strange....zy'.
Example: StrangeEntity in database is StrangeEntizy
![Context Configuration](https://github.com/Anselming/Study-EntityFramework/blob/master/assets/custompluralize-strangezy.png)

So, look at a custom convention to performe these requirements
![Context Configuration](https://github.com/Anselming/Study-EntityFramework/blob/master/assets/custompluralize-implementing.png)
![Context Configuration](https://github.com/Anselming/Study-EntityFramework/blob/master/assets/custompluralize-implementing2.png)

So, look at a database
![Context Configuration](https://github.com/Anselming/Study-EntityFramework/blob/master/assets/custompluralize-strangezy.png)

## Exercice 4 - Create another custom conventions
xxxx

## Exercice 5 - CRUD
xxxx

## Exercice 6 - Database Inicialyzing
xxxx

## Exercice 7 - Mapping by Attributes
Mapping by Attributes
- Relashionship one-one
- Relashionship one-many
- Relashionship many-many
- Relashionship many-many-many

## Exercice 8 - Mapping by Attributes
Mapping by Attributes
- Table per Hierarchy (TPH)
- Table per Type (TPT)
- Table per Concrete Class (TPC)

## Exercice 9 - Know all Attributes
xxxx

## Exercice 10 - Fluent
Fluent
- Entity Mapping
- Property Mapping

## Exercice 11 - From Database
xxxx

## Exercice 12 - Delete Cascade
xxxx

## Exercice 13 - Storage Procedure Mapping
xxxx

## Exercice 14 - Creating Seeds
xxxx

## Exercice 15 - Create database automatically
xxxx

## Exercice 16 - Using existing database
xxxx

## Exercice 17 - Generic Repository Pattern
xxxx

## Exercice 18 - Create custom Inicialization
xxxx

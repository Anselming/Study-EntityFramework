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

![Context Configuration](https://github.com/Anselming/Study-EntityFramework/blob/master/assets/pluralize-context-class.png)

If I change disableDatabaseInitialization to False it works, but i can create new tables on the database. So, i really do not want to do that on my production stage.
So, I rosolve keep disableDatabaseInitialization as false, but, on my Context Class I put this configuration for avoid initializing database.

![Context Class](https://github.com/Anselming/Study-EntityFramework/blob/master/assets/pluralizing-context-configuration.png)

So, thats work without changes the conventions.

## Exercice 3 - CRUD
xxxx

## Exercice 4 - Database Inicialyzing
xxxx

## Exercice 5 - Mapping by Attributes
Mapping by Attributes
- Relashionship one-one
- Relashionship one-many
- Relashionship many-many
- Relashionship many-many-many

## Exercice 6 - Mapping by Attributes
Mapping by Attributes
- Table per Hierarchy (TPH)
- Table per Type (TPT)
- Table per Concrete Class (TPC)

## Exercice 7 - Know all Attributes
xxxx

## Exercice 8 - Fluent
Fluent
- Entity Mapping
- Property Mapping

## Exercice 9 - From Database
xxxx

## Exercice 10 - Delete Cascade
xxxx

## Exercice 11 - Storage Procedure Mapping
xxxx

## Exercice 12 - Creating Seeds
xxxx

## Exercice 13 - Create database automatically
xxxx

## Exercice 14 - Using existing database
xxxx

## Exercice 15 - Generic Repository Pattern
xxxx



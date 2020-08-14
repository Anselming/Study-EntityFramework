# Study-EntityFramework
This repository is only a study about EntityFramemwork, organized in different C# Projects.
For that I used Visual Studio 2019 and .NET Framework 4.7

## Exercise 1 - Hello World Application
Consider one database called 'School_1' with one specific table called 'Students'.

![Students Table](https://github.com/Anselming/Study-EntityFramework/blob/master/assets/students-table.png)

![Students Data](https://github.com/Anselming/Study-EntityFramework/blob/master/assets/students-data.png)

![Students Table Structure](https://github.com/Anselming/Study-EntityFramework/blob/master/assets/students-table-structure.png)



## Exercise 2 - Pluralizing
If you have a table called 'Students' but the class on code wants to be called as 'Student'. How do you do that with pluralization?

Ok, normally, nothing special needed to be done, but in my case I have some throuble.
What happenning?
First, you need to know my configuration file. I configure EntityFramework > Contexts > Context tag with a specific attribute: disableDatabaseInitialization = true.
So, the convention of pluralizing does not work in my case.

![Context Class](https://github.com/Anselming/Study-EntityFramework/blob/master/assets/pluralizing-context-configuration.png)

If I change disableDatabaseInitialization to False it works, but I can create new tables on the database. So, i really do not want to do that at my production stage.
So, I decide to keep disableDatabaseInitialization as false, but, on my Context Class I put this configuration to avoid initializing database.

![Context Configuration](https://github.com/Anselming/Study-EntityFramework/blob/master/assets/pluralize-context-class.png)

So, that works without changing the conventions.

## Exercise 3 - Create custom Pluralizing Convention
In this exercise I created a custom convention.
Imigine this situation: You have a lot a of tables with common name patterns. 
You can use your database without needing to map any tables or any properties.
Besides that, you can garantee that your database is compliant with your name patterns.

Normally, a lot of people prefer configuring the modelCreating virtual method. 
In this case, you need to do all your tables.
![Context Configuration](https://github.com/Anselming/Study-EntityFramework/blob/master/assets/custompluralize-modelCreating.png)

For that i created a "Strange" convention.
Consider that: for each model named as 'Strange...y' there is a table named as 'Strange...zy'.
Example: StrangeEntity on database is StrangeEntizy

![Context Configuration](https://github.com/Anselming/Study-EntityFramework/blob/master/assets/custompluralize-strangezy.png)

So, look at a custom convention to perform these requirements

![Context Configuration](https://github.com/Anselming/Study-EntityFramework/blob/master/assets/custompluralize-implementing.png)

![Context Configuration](https://github.com/Anselming/Study-EntityFramework/blob/master/assets/custompluralize-implementing2.png)

So, look at a database

![Context Configuration](https://github.com/Anselming/Study-EntityFramework/blob/master/assets/custompluralize-strangezy.png)

## Exercise 4 - All native conventions
There are so many conventions. Now Im going to talk a little about each separated in main categories.

### ConceptualModelConventions
This category works creating the conceptual model by understanting what column is ID, how relashionship works, how pluralizing works ans something like that.

* System.Data.Entity.ModelConfiguration.Conventions.IdKeyDiscoveryConvention
* System.Data.Entity.ModelConfiguration.Conventions.AssociationInverseDiscoveryConvention
* System.Data.Entity.ModelConfiguration.Conventions.ForeignKeyNavigationPropertyAttributeConvention
* System.Data.Entity.ModelConfiguration.Conventions.OneToOneConstraintIntroductionConvention
* System.Data.Entity.ModelConfiguration.Conventions.NavigationPropertyNameForeignKeyDiscoveryConvention
* System.Data.Entity.ModelConfiguration.Conventions.PrimaryKeyNameForeignKeyDiscoveryConvention
* System.Data.Entity.ModelConfiguration.Conventions.TypeNameForeignKeyDiscoveryConvention
* System.Data.Entity.ModelConfiguration.Conventions.ForeignKeyAssociationMultiplicityConvention
* System.Data.Entity.ModelConfiguration.Conventions.OneToManyCascadeDeleteConventio
* System.Data.Entity.ModelConfiguration.Conventions.ComplexTypeDiscoveryConvention
* System.Data.Entity.ModelConfiguration.Conventions.StoreGeneratedIdentityKeyConvention
* System.Data.Entity.ModelConfiguration.Conventions.PluralizingEntitySetNameConvention
* System.Data.Entity.ModelConfiguration.Conventions.DeclaredPropertyOrderingConvention
* System.Data.Entity.ModelConfiguration.Conventions.SqlCePropertyMaxLengthConvention
* System.Data.Entity.ModelConfiguration.Conventions.PropertyMaxLengthConvention
* System.Data.Entity.ModelConfiguration.Conventions.DecimalPropertyConvention
* System.Data.Entity.Infrastructure.ModelContainerConvention

### ConceptualToStoreMappingConventions
* System.Data.Entity.ModelConfiguration.Conventions.ManyToManyCascadeDeleteConvention
* System.Data.Entity.ModelConfiguration.Conventions.MappingInheritedPropertiesSupportConvention

### ConfigurationConventions
* System.Data.Entity.Infrastructure.ModelNamespaceConvention
* System.Data.Entity.ModelConfiguration.Conventions.ForeignKeyPrimitivePropertyAttributeConvention
* System.Data.Entity.ModelConfiguration.Conventions.InversePropertyAttributeConvention
* System.Data.Entity.ModelConfiguration.Conventions.IndexAttributeConvention
* System.Data.Entity.ModelConfiguration.Conventions.ColumnAttributeConvention
* System.Data.Entity.ModelConfiguration.Conventions.StringLengthAttributeConvention
* System.Data.Entity.ModelConfiguration.Conventions.MaxLengthAttributeConvention
* System.Data.Entity.ModelConfiguration.Conventions.DatabaseGeneratedAttributeConvention
* System.Data.Entity.ModelConfiguration.Conventions.ConcurrencyCheckAttributeConvention
* System.Data.Entity.ModelConfiguration.Conventions.TimestampAttributeConvention
* System.Data.Entity.ModelConfiguration.Conventions.RequiredNavigationPropertyAttributeConvention
* System.Data.Entity.ModelConfiguration.Conventions.RequiredPrimitivePropertyAttributeConvention
* System.Data.Entity.ModelConfiguration.Conventions.KeyAttributeConvention
* System.Data.Entity.ModelConfiguration.Conventions.NotMappedPropertyAttributeConvention
* System.Data.Entity.ModelConfiguration.Conventions.TableAttributeConvention
* System.Data.Entity.ModelConfiguration.Conventions.ComplexTypeAttributeConvention
* System.Data.Entity.ModelConfiguration.Conventions.ComplexTypeAttributeConvention

### StoreModelConventions
* System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention
* System.Data.Entity.ModelConfiguration.Conventions.ColumnOrderingConventionStrict
* System.Data.Entity.ModelConfiguration.Conventions.ForeignKeyIndexConvention


## Exercise 5 - CRUD
xxxx

## Exercise 6 - Database Inicialyzing
xxxx

## Exercise 7 - Mapping by Attributes
Mapping by Attributes
- Relashionship one-one
- Relashionship one-many
- Relashionship many-many
- Relashionship many-many-many

## Exercise 8 - Mapping by Attributes
Mapping by Attributes
- Table per Hierarchy (TPH)
- Table per Type (TPT)
- Table per Concrete Class (TPC)

## Exercise 9 - Know all Attributes
xxxx

## Exercise 10 - Fluent
Fluent
- Entity Mapping
- Property Mapping

## Exercise 11 - From Database
xxxx

## Exercise 12 - Delete Cascade
xxxx

## Exercise 13 - Storage Procedure Mapping
xxxx

## Exercise 14 - Creating Seeds
xxxx

## Exercise 15 - Create database automatically
xxxx

## Exercise 16 - Using existing database
xxxx

## Exercise 17 - Generic Repository Pattern
xxxx

## Exercise 18 - Create custom Inicialization
xxxx

# Entity Framework Core Code First Migration using Separate Assembly

This blogpost explains how to achieve Entity Framework code first migrations having Models, DBContext, and 
Model Snapshot files in assembly different than web or startup projects.

By following this tutorial you will create a Class library project, data models with DataAnnotations validation, A
pplicationContext class implementing DBContext, and implement IDesignTimeDbContextFactory to avoid the use of startup class.

1. **DataModels** has Product and Category models.
1. **Migrations/initial/** contents EF Core migration script.
1. **StoreContext.cs** ApplicationContext of DBContext

![EF Core First Migration](https://geeksarray.com/images/blog/efcore-codefirst-create-database.png)

For step by step implementation [click here](https://geeksarray.com/blog/entity-framework-core-code-first-migration-using-separate-assembly) 

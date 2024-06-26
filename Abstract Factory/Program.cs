using Abstract_Factory;

CustomDatabaseOperations dbSql = new CustomDatabaseOperations(new MSSQLDatabaseFactory());
dbSql.GetAll();
dbSql.GetByID(1);
dbSql.RemoveByID(1);

CustomDatabaseOperations dbOracle = new CustomDatabaseOperations(new OracleDatabaseFactory());
dbOracle.GetAll();
dbOracle.GetByID(1);
dbOracle.RemoveByID(1);
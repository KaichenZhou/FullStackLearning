--1. What is index; types of indices; pros and cons
--Allows SQL Server to find data in a table without scanning the entire table
--Indexes are database objects based on table column for faster retrieval of data
--Clustered  Index and Non-Clustered Index
--Pros: index will help us improve retrieving speed -- improve performance of select
--Cons: slow down other DML statements, extra space


--2. What's the difference between Primary key and Unique constraint?
--PK cannot accept any null values
--One table only have one PK
--In a UC, no two rows in the table can have the same value for the columns 
--In a UC, only one null value is allowed per column.


--3. Tell me about check constraint
--CHECK constraints enforce  domain integrity by limiting the values that are accepted by a column 
--CHECK constraints determine the valid values from a logical expression that is not based on data in another column 

--4. Difference between temp table and table variable
--Storage: both Temp Tables and Table Variables are stored in tempDb
--Scope: Temp Tables scoped local/global; Table Variables scoped for current batch
--Temp Tables for large data; Table Variables for smaller data 
--Usage: Temp Tables not in Stored Procedure, Functions; Table Variables can be used 
--Structure: Temp Tables can create index/ constraints except Foreign key; Table Variables cannot 


--5. Difference between WHERE and HAVING
--The HAVING clause of the SELECT statement allows you to specify a search condition on a query using GROUP BY and/or an aggregated value
--The HAVING clause is used after the GROUP BY clause. 
--The WHERE clause, in contrast, is used to qualify the rows that are returned before the data is aggregated or grouped. 
--HAVING qualifies the aggregated data after the data has been grouped or aggregated.


--6. Difference between RANK() and DenseRank() ¡ª value gap
--RANK(): if there is the same rank ,the there will be a gap for the next rank
--DENSE_RANK(): will not skip any number in rank if there is a tie


--7. COUNT(*) vs. COUNT(colName)
--count(*) will include null values, but count(colname) will not include null values

--8. What's the difference between left join and inner join? JOIN and Subquery, which one has a better performance, why?
-- Left outer join: return all records from the left table, and the matching records from the right table, 
--for the non-matching records in the right table, the result set will return us null values
--Inner join: return the records that have matching values in both tables
--subquery vs. join
--JOIN can only be used in FROM; Subquery can be used in SELECT, WHERE, FROM, ORDER BY 
--Usually join will have a better performance than subquery
--Because the join works faster than subquery 


--9. What is correlated subquery
--Correlated Subquery: inner query is dependent on the outer query
--a correlated subquery (also known as a synchronized subquery) is a subquery (a query nested inside another query) 
--that uses values from the outer query. Because the subquery may be evaluated once for each row processed by the outer query, 
--it can be inefficient.

--10. What is a CTE, why do we need CTE?
--Specifies a temporary named result set
--Improve readability and manageability of complex SQL Statements


--11. What does SQL Profiler do?
--SQL Server Profiler is an interface to create and manage traces and analyze and replay trace results. 
--Events are saved in a trace file that can later be analyzed or used to replay a specific series of steps when diagnosing a problem.

--12. What is SQL injection, how to avoid SQL injection?
--SQL injection is a code injection technique that might destroy your database.
--SQL injection is one of the most common web hacking techniques.
--SQL injection is the placement of malicious code in SQL statements, via web page input.
--To protect a web site from SQL injection, you can use SQL parameters.
--SQL parameters are values that are added to an SQL query at execution time, in a controlled manner.

--13. Difference between SP and user defined function? When to use SP when to use function?
--There are two different  ways to execute  a stored procedure.  
--The first  and most common approach is for an application  or user to call the procedure. 
--The second approach is to set the procedure to run automatically when  an instance of SQL Server starts.  
--When  a procedure is called by an application or user, the Transact-SQL EXECUTE or EXEC keyword is explicitly stated  in the call. 
--Alternatively, the procedure can be called and executed without the keyword if the procedure is the first statement in the Transact-SQL batch. 
--It is possible to call Sp directly from C#. 
--Creates a user-defined  function  in SQL Server and Azure SQL Database.  
--A user-defined  function is a Transact-SQL or common language runtime (CLR) routine  that accepts parameters,  
--performs an action, such as a complex calculation, and returns the result of that action as a value. 
--The return value can either be a scalar (single) value or a table. 
--Function can be only used in a SQL statement, mostly in a select  statement, or representing  a data or a dataset

--14. Criteria of Union and Union all? Difference between UNION and UNION ALL
--Unions: Concatenates the results of two queries into a single result set.
--Union removes duplicate records (where all columns in the results are the same), Union All does not.
--There is a performance hit when using Union vs Union All, 
--since the database server must do additional work to remove the duplicate rows, 
--but usually you do not want the duplicates especially in reports.
--The condition of using Unions are that the number of columns and data type of each column from both result set should match in the order they are given.
--Union & Union All are called set operators. There are two other types of SET Operators known as Intersect and Except. 
--As the name suggests, they only return intersecting values and values that do not match respectively.

--15. Steps you take to improve SQL Queries
--1 Favor set-based  logic over procedural  or cursor logic
--2. Test query  variations for performance
--3. Avoid query  hints.
--4. correlated subqueries  to improve performance.
--5. Avoid using a scalar user-defined  function in the WHERE clause
--6. Use table-valued  user-defined  functions as derived  tables.
--7 Avoid unnecessary  GROUP BY columns
--8 .Use CASE  expressions to include variable logic in a query
--9 Divide  joins into temporary  tables when you query very large tables.
--10. Refactoring Cursors into Queries


--16. concurrency problem in transaction
--Concurrency is a situation where two users are trying to access the same information or data
--and while they are accessing the same information we do not want any kind of inconsistency result or abnormal behavior.
-

--17. what is deadlock, how to prevent
--Deadlocks occur when two processes want to access resources that are mutually being locked by each other
--In terms of SQL Server, a deadlock occurs when two (or more) processes lock the separate resource.
--Avoid:
--keep your transactions short and quick.
--data design must be normalized, and application access server objects must be in the exact same order for every instance
-- you must not allow user input during transactions (all input should be collected PRIOR to the transaction).

--18. what is normalization, 1NF - BCNF, benefits using normalization
--Database Normalization is a process of organizing data to minimize redundancy (data duplication), 
--which in turn ensures data consistency. 
--Normalization has a series of steps called ¡°Forms¡±, the more steps you take the more normalized your tables are
--1NF = it¡¯s all about atomic values. One cell, one value. No repeating groups
--2NH = First Normal Form + No Partial Dependency
--3NF = Second Normal Form + No Transitive Dependency
--BCNF = Stricter version of 3NF
--Benefits: it usually divides a large table into smaller ones, so it is more efficient.


--19. what are the system defined databases?
--master, model, tempdb, mssql system resource(hidden), msdb 


--20. composite key
--A composite key in SQL can be defined as a combination of multiple columns, 
--and these columns are used to identify all the rows that are involved uniquely. 
--Even though a single column can¡¯t identify any row uniquely, 
--a combination of over one column can uniquely identify any record. 
--In other words, the combination key can also be described as a primary key that is being created by using multiple columns.
--However, the data types of different columns could differ from each other. 
--You can also combine all the foreign keys to create a composite key in SQL

--21. candidate key
--A key that is not a PK but eligible to be a PK. Mostly it is a unique key without null  value.
--Like a primary key, a candidate key also uniquely identifies a row in a table. 
--Note that a table can have only one primary key, but can have any number of candidate keys.

--22. DDL vs. DML
--DDL:
--Allows to respond to DDL events issued against the database server
--SQL Server  supports only AFTER triggers for DDL
--To reject the schema change that caused it to fire issue ROLLBACK TRAN command in the trigger
--DDL Triggers can be created at¨CDatabase level¨CServer  (instance) level
--Database level trigger¨CAllows to react to database-level events, such as creating, altering, or dropping objects
--DML:
--OUTPUT clause for DML
--Ability to return rows as part of DML operations
--OUTPUT can be used along with INSERT/UPDATE and DELETE Statements
--Immediate access to the INSERTED and DELETED system tables to see the new value/old value for specific columns.
--Option to store returned rows into another table

--23. ACID property
--ACID is the properties of transactions
--A: Atomicity -- work is atomic
--C: Consistency -- whatever happends in the middle of the transaction, this property will never leave your db in half-completed state
--I: Isolation -- two transactions will be isolated from each other by locking the resource
--D: Durability -- once the transaction is completed, then the changes it has made to the db will be permanent


--24. table scan vs. index scan
--A table scan is where the table is processed row by row from beginning to end.
--An index scan is where the index is processed row by row from beginning to end.


--25. Difference between Union and JOIN
--Join combines data from many tables based on a matched condition between them, while SQL combines the result-set of two or more SELECT statements.
--Join combines data into new columns. Union combines data into new rows
--Number of columns selected from each table may not be same£¬while number of columns selected from each table should be same.
--Datatypes of corresponding columns selected from each table can be different, while datatypes of corresponding columns selected from each table should be same.
--Join may not return distinct columns.	Union returns distinct rows.

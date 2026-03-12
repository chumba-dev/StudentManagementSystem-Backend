**Student Management System - Phase 1: Database Design**

This phase focused on designing and implementing a relational database to manage academic records. The system tracks students, departments, courses, and enrollments using Microsoft SQL Server.

Objectives
1. Perform requirements analysis for a Student Management Information System (SMIS).

2. Design an Entity-Relationship (ER) model.

3. Implement 3rd Normal Form (3NF) to ensure data integrity.

4. Script and execute DDL (Data Definition Language) and DML (Data Manipulation Language).

**Database Schema**

The database consists of four primary tables:

1. Departments: Stores academic department details.

2. Students: Stores student profiles linked to departments.

3. Courses: Catalog of available subjects.

4. Enrollments: A junction table managing the many-to-many relationship between students and courses.

**Technical Stack**

- Database Engine: Microsoft SQL Server 2025

- Query Language: T-SQL (Transact-SQL)

- Tooling: SQLCMD / SQL Server Management Studio (SSMS)

**Key SQL Features Implemented**
- Primary Keys & Identity: Used for unique record identification and auto-incrementing IDs.

- Foreign Keys: Enforced referential integrity between tables.

- Check Constraints: Validated data entry (e.g., ensuring course credits are greater than zero).

- Complex Joins: Implemented multi-table joins to generate comprehensive student academic reports.

**How to Run the Scripts**

Ensure SQL Server is installed and running.

Connect to your server using sqlcmd or SSMS.

Run the scripts located in the /scripts folder in the following order:

- Schema.sql (Creates the tables)

- SeedData.sql (Populates the tables with sample data)

# Student Management System

## Technologies Used
- C# (.NET Framework 4.7.2)
- Windows Forms
- MS SQL Server

---

## Requirements
- Visual Studio
- SQL Server (Express or higher)

---

## Setup Instructions

1. Clone or download this repository.
2. Open SQL Server Management Studio.
3. Open the file: StudentManagementSystem.sql
4. Click **Execute** to create the database.
5. Open the project in Visual Studio.
6. Run the project.

---

## Database Connection

If the system cannot connect to SQL Server,  
update the connection string inside `Login.cs`.

Example:

```
Data Source=.\SQLEXPRESS;
Initial Catalog=Student;
Integrated Security=True;
```

---

Developed for Academic Submission.
# Day 07: Database Foundations & Relational Schemas

## 1. Relational Table Designs

### Table: `Students`
| Column Name | Data Type | Constraints | Description |
| :--- | :--- | :--- | :--- |
| `student_id` | INT | PRIMARY KEY, AUTO_INCREMENT | Unique identifier for each student |
| `first_name` | VARCHAR(50) | NOT NULL | Student's legal first name |
| `last_name` | VARCHAR(50) | NOT NULL | Student's legal last name |
| `email` | VARCHAR(100) | NOT NULL, UNIQUE | Unique contact email |

### Table: `Courses`
| Column Name | Data Type | Constraints | Description |
| :--- | :--- | :--- | :--- |
| `course_code` | VARCHAR(10) | PRIMARY KEY | Unique code (e.g., 'CS101') |
| `title` | VARCHAR(100) | NOT NULL | Full course name |
| `credits` | INT | NOT NULL, CHECK (credits > 0) | Academic weight of course |

### Table: `Enrollments` (The Join Table)
| Column Name | Data Type | Constraints | Description |
| :--- | :--- | :--- | :--- |
| `enrollment_id`| INT | PRIMARY KEY, AUTO_INCREMENT | Unique enrollment record ID |
| `student_id` | INT | FOREIGN KEY references `Students(student_id)` | Links to the student |
| `course_code` | VARCHAR(10) | FOREIGN KEY references `Courses(course_code)` | Links to the course |

---

## 2. Standard SQL Query Examples
Below are the conceptual SQL queries used to create this schema and fetch data safely.

### Creating the Tables:
```sql
CREATE TABLE Students (
    student_id INT PRIMARY KEY AUTO_INCREMENT,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL
);



-- Finds all courses a specific student is enrolled in
SELECT s.first_name, s.last_name, c.title 
FROM Enrollments e
JOIN Students s ON e.student_id = s.student_id
JOIN Courses c ON e.course_code = c.course_code;
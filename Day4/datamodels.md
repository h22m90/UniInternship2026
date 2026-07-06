# Day 04: Data Architecture & Object Modeling

## 1. System Entity Blueprints

### A. Student Entity
| Property Name | Data Type | Constraints / Rules | Description |
| :--- | :--- | :--- | :--- |
| `Id` | Integer / Guid | Primary Key, Unique | Unique system tracker for the student. |
| `FirstName` | String (Text) | Required, Max 50 chars | Legal first name. |
| `LastName` | String (Text) | Required, Max 50 chars | Legal last name. |
| `Email` | String (Text) | Required, Must contain `@` | University-issued email address. |
| `EnrolledDate`| DateTime | Auto-generated | The exact day they joined the system. |

### B. Course Entity
| Property Name | Data Type | Constraints / Rules | Description |
| :--- | :--- | :--- | :--- |
| `CourseCode` | String (Text) | Primary Key, Unique | e.g., "CS101", "NET202" |
| `Title` | String (Text) | Required, Max 100 chars | Full name of the academic course. |
| `Credits` | Integer | Range: 1 to 6 | Academic credit weight. |

---

## 2. System Entity Relationships (ERD Mapping)
- **Many-to-Many Relationship:** A **Student** can enroll in multiple **Courses**, and a **Course** can contain multiple **Students**.
- To handle this cleanly in backend architecture, we will eventually implement a join entity called `Enrollment` containing:
  - `EnrollmentId`
  - `StudentId` (Foreign Key referencing Student)
  - `CourseCode` (Foreign Key referencing Course)
  - `Grade` (Floating Point Number / Character)
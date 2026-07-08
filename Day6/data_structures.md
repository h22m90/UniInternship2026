# Day 06: Memory Management & Data Structure Efficiency

## 1. Architectural Comparison Matrix

| Property / Feature | List / Array | HashMap / Dictionary |
| :--- | :--- | :--- |
| **Storage Pattern** | Sequential, ordered indexes | Key-Value pairs |
| **Lookup Strategy** | Scans sequentially (Linear Search) | Direct address computation (Hashing) |
| **Search Time Complexity** | Scales poorly with large datasets | Remains constant regardless of dataset size |
| **Best Used For...** | Iterating through all records sequentially | Instant lookups using a unique identifier (ID) |

---

## 2. Pseudocode Implementation Examples

### Example A: Storing Courses in a Sequential List
```text
// Good for printing a clean schedule or timeline sequentially
List<Course> universityCourses = NEW List<Course>()
universityCourses.Add(Course1)
universityCourses.Add(Course2)


// Optimized for high-speed backend lookup systems
Dictionary<Integer, Student> studentRegistry = NEW Dictionary<Integer, Student>()

// Registering a student using their unique ID as the Key
studentRegistry.Put(10024, StudentObject)

// Instant retrieval without scanning the whole system
Student foundStudent = studentRegistry.Get(10024)
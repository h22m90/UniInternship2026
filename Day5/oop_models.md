# Day 05: Object-Oriented Data Modeling & Encapsulation

## 1. Class Definitions

### A. Student Class Blueprint
```text
CLASS Student
    // Properties (Encapsulated System Data)
    PRIVATE Integer Id
    PRIVATE String FirstName
    PRIVATE String LastName
    PRIVATE String Email
    PRIVATE List<Course> EnrolledCourses

    // Constructor: Initializes a new Student instance
    CONSTRUCTOR(Integer id, String firstName, String lastName, String email)
        THIS.Id = id
        THIS.FirstName = firstName
        THIS.LastName = lastName
        THIS.Email = email
        THIS.EnrolledCourses = NEW List<Course>()
    END CONSTRUCTOR

    // Business Logic Method: Enrolls student in a course safely
    METHOD EnrollInCourse(Course course)
        IF NOT THIS.EnrolledCourses.Contains(course) THEN
            THIS.EnrolledCourses.Add(course)
            PRINT "Successfully enrolled in: " + course.GetTitle()
        ELSE
            PRINT "Error: Already enrolled in this course."
        END IF
    END METHOD
END CLASS


CLASS Course
    PRIVATE String CourseCode
    PRIVATE String Title
    PRIVATE Integer Credits

    CONSTRUCTOR(String courseCode, String title, Integer credits)
        THIS.CourseCode = courseCode
        THIS.Title = title
        THIS.Credits = credits
    END CONSTRUCTOR

    METHOD GetTitle()
        RETURN THIS.Title
    END METHOD
END CLASS
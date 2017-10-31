# Unit Test Exercise

## Goal

Learn how to write unit tests


## Requirements

* Create a single file that will implement the product features and the tests
* Use Test-Driven Development (TDD) to build the code
* Use Pair Programming to complete this assignment
* Implement tests for all the code features
* Solve the puzzles in the order listed


## Steps

1. Create a code file called **unit_test.py** (or unit_test.cs, unit_test.java, etc.)

2. Create a function to test all the features and invoke it automatically.  Name it **test_user()**.

3. Create a test to verify creation of a User class object.  Name it **test_create()**.  This should fail.

4. Make **test_create()** pass by creating an object class called User.

5. Test for properties to be set for first name and last name.  This should fail.  Now add code to create and set those properties.

6. Test for email property.  Then add it to the User class.

7. Create four test cases for creating user objects with different names.

8. Extract the duplication by creating **test_a_name(first,last,name)** function.  Make sure that all tests still pass.

9. Create a function that adds a number of users from a list, verifying each one.

10. Test that the User creation will throw an exception when any property is missing.

11. Publish your results in your student directory in the Github UNC-CS350 repo.


## Design

Use the following patterns to complete this exercise.

    User class
        first
        last
        email
        name()

    test_one_thing
        t = test_object
        x = process(t)
        answer = correct_answer
        assert (x == answer)

    test_for_exception
        try
            t = test_object
            x = process(t)
            answer = correct_answer
            assert (False)
        catch
            pass



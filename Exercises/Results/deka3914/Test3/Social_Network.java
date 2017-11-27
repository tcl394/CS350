
import java.util.ArrayList;

public class Social_Network {


    
    public String firstName;
    public String lastName;
    public String age;
    public ArrayList<String> list = new ArrayList<String>();
    
    
    
    public void setList(String first, String last, String age)
    {
        setFirstName(first);
        setLastName(last);
        setAge(age);
    }
    

    public String getFirstName()
    {
     return firstName;
    }

    public String getLastName()
    {
     return lastName;
    }

    public String getAge()
    {
      return age;
    }
    


    public void setFirstName( String FirstName )
    {
     firstName = FirstName;
    }

    public void setLastName( String LastName )
    {
     lastName = LastName;
    }

    public void setAge(String Age)
    {
      age = Age;
    }


    public void addFriend()
    {   
        list.add(firstName);
        list.add(lastName);
        list.add(age);
    }

    public void removeFriend()
    {
        list.remove(firstName);
        list.remove(lastName);
        list.remove(age);
    }
    
 

 @Override
 public String toString()
 {
   return String.format( "Name: %s\nStudent Last Name: %s\nStudent Age: %s\nStudent", firstName, lastName, age);
 }
    

}

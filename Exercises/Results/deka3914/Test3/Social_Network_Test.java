
import java.util.Scanner; 


public class Social_Network_Test 
{
    public static void main(String[] args) 
    {
        Scanner input = new Scanner(System.in);
        
        System.out.println("1.Add a friend");
        System.out.println("2.Remove a friend"); 
        System.out.println("3.Display all friends");
        System.out.println("4.Exit Program");
        
        int selection = input.nextInt();
        
        FriendsList bornList = new FriendsList();
        
        int count = 0;
        
        while (selection != 4)
        {
            int number = 0;
          
            if (selection == 1)
            {
                System.out.printf("Whats the first Name: ");
                String first = input.next();
                System.out.println("Whats there Last Name: ");
                String last = input.next();
                System.out.println("Whats there Age");
                String age = input.next(); 
                bornList.setList(first, last, age);
                bornList.addFriend();
                count++;
            }
            
            if (selection == 2)
            {
                System.out.printf("Whats the first Name: ");
                String first = input.next();
                System.out.println("Whats there Last Name: ");
                String last = input.next();
                System.out.println("Whats there Age");
                String age = input.next();
        
                bornList.setList(first, last, age);  
                bornList.removeFriend();
            }
            
            if (selection == 3)
            {

                for(int i= 0; i < 1;i++)
                {
                System.out.println(bornList.list);
                }
            }
          
                System.out.println("1.Add a friend (First Name, Last Name, Age)");
                System.out.println("2.Remove a friend"); 
                System.out.println("3.Display all friends");
                System.out.println("4.Exit Program");
                selection = input.nextInt(); 
            }
        } 
    } 

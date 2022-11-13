using que15;

var b = new Account();
int option, i;

Console.WriteLine("Welcome to xyz Bank");

while(true)
{
    Console.WriteLine("1.Create account");
    Console.WriteLine("2.Deposite");
    Console.WriteLine("3.Withdraw");
    Console.WriteLine("4.Balance");

    Console.WriteLine("Enter the option:");
    option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            b.create();
            break;
        case 2:
            b.deposit();
            break;
        case 3:
            b.withdraw();
            break;

        case 4:
            b.balance();
            break;  
        default:
            Console.WriteLine("wrong option");
            break;
    }
    Console.WriteLine("enter 1 to exist");
    i= int.Parse(Console.ReadLine());
    if(i==1)
    
     break;
    


}
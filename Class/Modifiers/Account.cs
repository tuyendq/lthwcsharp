namespace ModifiersDemo;

public class Account {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public decimal Balance { get; set; }

    public Account(string firstName, string lastName, decimal balance = 0)
    {
        FirstName = firstName;
        LastName = lastName;
        Balance = balance;
    }
    
    public string GetOwner() {
        return $"{FirstName} {LastName}";
    }

}
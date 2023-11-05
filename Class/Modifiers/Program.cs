namespace ModifiersDemo
{
    class Program
    {
        static void Main() {
            Account account1 = new Account("Tuyen", "Dang");
            System.Console.WriteLine(account1.GetOwner());
        }
    }
}

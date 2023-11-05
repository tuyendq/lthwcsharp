namespace ModifiersDemo;

    class Program
    {
        static void Main() {

            // Play with Account class
            Account account1 = new Account("Tuyen", "Dang");
            System.Console.WriteLine(account1.GetOwner());

            // System.Console.WriteLine(account1);  // Should return Namespace.Classname

        }
    }


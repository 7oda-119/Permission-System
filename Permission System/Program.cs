namespace Permission_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter permissions: ");
            string[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Permission permissions = Permission.None;
            for(int i = 0; i < arr.Length; i++)
            {
                Permission p = Enum.Parse<Permission>(arr[i]);
                permissions |= p;
            }

            Console.WriteLine($"Granted: {permissions} ({(int)permissions})");

            Permission add = ReadPermision("Enter permission to add: ");
            permissions |= add;
            Console.WriteLine($"Add {add}: {permissions} ({(int)permissions})");

            Permission revoke = ReadPermision("Enter permission to revoke: ");
            permissions &= ~revoke;
            Console.WriteLine($"Revoke {revoke}: {permissions} ({(int)permissions})");

            Console.Write("Has:");
            if((permissions & Permission.Read) !=0)
                Console.Write(" Read");
            if((permissions & Permission.Write) != 0)
                Console.Write(" Write");
            if((permissions & Permission.Delete) != 0)
                Console.Write(" Delete");
            if((permissions & Permission.Execute) != 0)
                Console.Write(" Execute");
        }

        static Permission ReadPermision(string message)
        {
            while (true)
            {
                Console.Write(message);

                if (Enum.TryParse<Permission>(Console.ReadLine(), ignoreCase: true, out Permission p))
                    return p;
            }
        }

    }


}

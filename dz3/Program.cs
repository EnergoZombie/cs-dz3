

namespace dz3
{
    internal class Website
    {
        private string name = "Name";
        private string path = @"\";
        private string description = "Description";
        private string address = "https://address";

        public string Name { 
            get { return name; } 
            set 
            { 
                if (!string.IsNullOrEmpty(value)) { name = value; }
                else { Console.WriteLine("Invalid name"); }
            }
        }
        public string Path
        {
            get { return path; }
            set 
            {
                if (value.StartsWith(@"C:\") || value.StartsWith(@"\") ) { path = value;  }
                else { Console.WriteLine("Invalid path"); }
            }
        }
        public string Description
        {
            get { return description; }
            set 
            { 
                if(!string.IsNullOrEmpty(value)) { description = value; }
                else { Console.WriteLine("Invalid description"); }
            }
        }
        public string Address
        {
            get { return address; }
            set 
            { 
                if (value.StartsWith("https://") && !value.Contains(' ')) { address = value; }
                else { Console.WriteLine("Invalid address"); }
            }
        }

        public void Input()
        {
            Console.Write("Enter website name: ");
            Name = Console.ReadLine();
            Console.Write("Enter website description: ");
            Description = Console.ReadLine();
            Console.Write("Enter website address: ");
            Address = Console.ReadLine();
            Console.Write("Enter website path: ");
            Path = Console.ReadLine();
        }
        public override string ToString()
        {
            return $"{name}   -   {description}   -   {address}   -   {path}";
        }
    }

    internal class Journal
    {
        private string name = "Name";
        private DateTime date = DateTime.Today;
        private string description = "Description";
        private string phone = "Phone number";
        private string email = "email@gmail.com";

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value)) { name = value; }
                else { Console.WriteLine("Invalid name"); }
            }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrEmpty(value)) { description = value; }
                else { Console.WriteLine("Invalid description"); }
            }
        }
        public string Phone
        {
            get { return phone; }
            set
            {
                if (!string.IsNullOrEmpty(value)) { phone = value; }
                else { Console.WriteLine("Invalid phone number"); }
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (value.ToLower().EndsWith("@gmail.com") && !value.Contains(' ')) { email = value; }
                else { Console.WriteLine("Invalid email"); }
            }
        }

        public void Input()
        {
            Console.Write("Enter journal name: ");
            Name = Console.ReadLine();
            Console.Write("Enter journal description: ");
            Description = Console.ReadLine();
            Console.Write("Enter journal creation date: ");
            Date = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter journal phone number: ");
            Phone = Console.ReadLine();
            Console.Write("Enter journal email: ");
            Email = Console.ReadLine();

        }
        public override string ToString()
        {
            return $"{name}   -   {description}   -   {date}   -   {phone}   -   {email}";
        }
    }

    internal class Shop
    {
        private string name = "Name";
        private string description = "Description";
        private string address = "Address";
        private string phone = "Phone number";
        private string email = "email@gmail.com";

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value)) { name = value; }
                else { Console.WriteLine("Invalid name"); }
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrEmpty(value)) { description = value; }
                else { Console.WriteLine("Invalid description"); }
            }
        }
        public string Address
        {
            get { return address; }
            set
            {
                if (!string.IsNullOrEmpty(value)) { address = value; }
                else { Console.WriteLine("Invalid address"); }
            }
        }
        public string Phone
        {
            get { return phone; }
            set
            {
                if (!string.IsNullOrEmpty(value)) { phone = value; }
                else { Console.WriteLine("Invalid phone number"); }
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (value.ToLower().EndsWith("@gmail.com") && !value.Contains(' ')) { email = value; }
                else { Console.WriteLine("Invalid email"); }
            }
        }

        public void Input()
        {
            Console.Write("Enter name:");
            Name = Console.ReadLine();
            Console.Write("Enter description:");
            Description = Console.ReadLine();
            Console.Write("Enter address:");
            Address = Console.ReadLine();
            Console.Write("Enter phone number:");
            Phone = Console.ReadLine();
            Console.Write("Enter email:");
            Email = Console.ReadLine();
        }
        public override string ToString()
        {
            return $"{name}   -   {description}   -   {address}   -   {phone}   -   {email}";
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Website website = new Website();
            website.Input();
            Console.WriteLine($"Website: {website.ToString()}" );

            Journal journal = new Journal();
            journal.Input();
            Console.WriteLine($"Journal: {journal.ToString()}");

            Shop shop = new Shop();
            shop.Input();
            Console.WriteLine($"Shop: {shop.ToString()}");
        }
    }
}

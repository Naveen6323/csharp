using System.Collections;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;

namespace Events
{
    internal class Events
    {
        public static void Main(string[] args)
        {
            //    BusinessLogic b = new BusinessLogic();
            //b.ProcessCompleted += b_ProcessCompleted;
            ////b.ProcessCompleted += b_ProcessCompleted2;
            //b.StartProcess();
            //Products p = new Products();
            //p.ProductAdded += ProductAddedSuccessfully;
            //p.AddProduct("boost");
            //p.AddProduct("Horlicks");
            ClosureExamples e = new ClosureExamples();
            //Func<int, int> c = ClosureExamples.Closure();
            //Func<int,int> b = ClosureExamples.Closure();
            // Console.WriteLine(c(10));
            //Console.WriteLine(b(1));
            //Console.WriteLine(c(10));
            //Console.WriteLine(c(10));

            //List<int> a  = new List<int>();
            //a.Add(1);
            //a.Add(2);
            //a.Add(3);
            //Console.WriteLine(a[a.Count()-1]);
            //PriorityQueue<int>


            //AddressBook a = new AddressBook();
            //a.contactAdded += (sender,contact) => Console.WriteLine($"contact added: {contact}");
            //a.contactRemoved += (sender, c) => Console.WriteLine($"contact removed: {c}");
            //a.contactUpdated += (sender, contact) => Console.WriteLine($"contact updated: {contact}");
            //Contacts c = new Contacts("naveen", 9730233998);
            //Contacts c1 = new Contacts("sam", 65974123);
            //a.AddContact(c);
            //a.AddContact(c1);
            //a.UpdateContact("naveen",8787);
            //a.RemoveContact("sam");
            //a.DisplayContacts();

        }

        private static void ProductAddedSuccessfully(object sender,ProductAddedEventArgs e)
        {
            Console.WriteLine("product added "+e.ProductName);
        }


        public static void b_ProcessCompleted(object sender,EventArgs e)
        {
            Console.WriteLine("completed");
        }

        public static void b_ProcessCompleted2(object sender,EventArgs e)
        {
            Console.WriteLine("2");
        }
    }

    //public delegate void Notify();

    public class BusinessLogic
    {
        public event EventHandler ProcessCompleted;

        public void StartProcess()
        {
            Console.WriteLine("process started...");
            System.Threading.Thread.Sleep(3000);
            OnProcessCompleted(EventArgs.Empty);
        }

        public virtual void OnProcessCompleted(EventArgs e)
        {
            ProcessCompleted?.Invoke(this,e);
        }
        
    }

    class ProductAddedEventArgs : EventArgs
    {
        public string ProductName { get; private set; }

        public ProductAddedEventArgs(string name)
        {
            ProductName = name;
        }
    }

    public class Contacts
    {
        public string name { get;  set; }
        public long phoneNo { get;   set; }
        public Contacts(string name, long phoneNo)
        {
            this.name = name;
            this.phoneNo = phoneNo;
        }

        public override string ToString()
        {
            return $"name= {name}, Phone number = {phoneNo}";
        }
    }

    public class AddressBook
    {
        private List<Contacts> l = new List<Contacts>();
        public event EventHandler<Contacts> contactAdded;
        public event EventHandler<Contacts> contactRemoved;
        public event EventHandler<Contacts> contactUpdated;

        public void AddContact(Contacts c)
        {
            l.Add(c);
            contactAdded?.Invoke(this,c);
        }
        public void RemoveContact(string name)
        {
            var contact = l.Find(x => x.name == name);
            if (contact != null)
            {
                l.Remove(contact);
                contactRemoved?.Invoke(this,contact);
            }
        }

        public void UpdateContact(string name, long phone)
        {
            var contact = l.Find(x => x.name == name);
            if (contact != null)
            {
                contact.phoneNo=phone;
                contactUpdated?.Invoke(this,contact);
            }
        }

        public void DisplayContacts()
        {
            foreach (var c in l)
            {
                Console.WriteLine(c.ToString());
            }
        }
    }
    class Products
    {
        List<string> l = new List<string>();
        public event EventHandler<ProductAddedEventArgs> ProductAdded;
        public  void AddProduct(string a)
        {
            l.Add(a);
            OnAddProduct(new ProductAddedEventArgs(a));
        }

        protected virtual void OnAddProduct(ProductAddedEventArgs e)
        {
            ProductAdded?.Invoke(this,e);
        }
    }

    class ClosureExamples
    {
        public static Func<int, int> Closure()
        {
            int x = 10;
            Func<int, int> inc = y =>
            {
                return ++x;
            };
            return inc;
        }

        public  void A()
        {
            int x = 2;
            Console.WriteLine(++x);
        }
    }

    
}





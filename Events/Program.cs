using System.Collections;
using System.Runtime.Intrinsics.X86;

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
            Products p = new Products();
            p.ProductAdded += ProductAddedSuccessfully;
            p.AddProduct("boost");
            p.AddProduct("Horlicks");
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

    
    
}


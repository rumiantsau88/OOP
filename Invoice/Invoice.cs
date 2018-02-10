using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    class Invoice
    {
        readonly private int _account;

        public int Account
        {
            get { return _account; }
        }

        readonly private string _customer;

        public string Customer
        {
            get { return _customer; }
        }

        readonly private string _provider;

        public string Provider
        {
            get { return _provider; }
        }

        private string _article;

        public string Article
        {
            get { return _article; }
            set { _article = value; }
        }
        private int _quantity;

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }


        public Invoice(int account, string customer, string provider)
        {
            _account = account;
            _customer = customer;
            _provider = provider;
        }

        public void SummArticle(bool nds)
        {
           double cost;
            switch (Article)
            {
                case "notebook": cost = 1000;
                    break;
                case "usb":
                    cost = 200;
                    break;
                case "smartphone": cost = 333;
                    break;

                default:
                    Console.WriteLine("Nima takoga!");
                    cost = 0;
                    break;
                
            }
            if (nds==true)
            {
                cost = cost * 7 / 6;
            }
            Console.WriteLine("Сумма заказа:${0}",cost* Quantity);
        }

    }
}

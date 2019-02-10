using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccessLayer.DataModels
{
    public class Product
    {
        public Product()
        {

        }
                
        public int ProductID { get; set; }
                        
        public string ProductName { get; set; }
                
        public int CategoryID { get; set; }
                
        public int QuantityPerUnit { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitsInStock { get; set; }
                
        public int ReorderLevel { get; set; }
                
        public bool Discontinued { get; set; }

        public virtual Category Category { get; set; }
    }
}

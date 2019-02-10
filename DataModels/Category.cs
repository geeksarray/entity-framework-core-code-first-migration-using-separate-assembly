using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccessLayer.DataModels
{
    public class Category
    {
        public Category()
        {

        }
                
        public int CategoryID { get; set; }
                 
        public string CategoryName { get; set; }
                    
        public string Description { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}

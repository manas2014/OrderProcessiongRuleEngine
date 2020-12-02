using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingRuleEngine.Models
{
    public class Video : Product<int>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public void AddVideo()
        {

        }
    }
}

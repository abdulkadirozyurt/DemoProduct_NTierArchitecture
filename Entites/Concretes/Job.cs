using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Concretes
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public List<Customer> Customers { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
	public class CustomerAccountProcess
	{
		[Key]
		public int CustomerAccountProcessID { get; set; }
		public string ProcessType { get; set; }
		public decimal Amount { get; set; }
		public DateTime ProcessDate { get; set; }
	}
}

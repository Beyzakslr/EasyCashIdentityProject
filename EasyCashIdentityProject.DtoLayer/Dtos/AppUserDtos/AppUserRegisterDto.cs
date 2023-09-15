using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos
{
	public class AppUserRegisterDto
	{
		//[Required(ErrorMessage ="Ad alanı zorunludur")]
		//[Display(Name ="isim:")]
		//[MaxLength(30,ErrorMessage ="En fazla 30 karakter girebilirsiniz")]
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Email { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string ConfirmPassword { get; set; }
	}
}

using EasyCashIdentityProject.BusinessLayer.Abstract;
using EasyCashIdentityProject.DataAccessLayer.Concrete;
using EasyCashIdentityProject.DtoLayer.Dtos.CustomerAccountProcessDtos;
using EasyCashIdentityProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EasyCashIdentityProject.PresentationLayer.Controllers
{
    public class SendMoneyController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly ICustomerAccountProcessService _customerAccountProcessService;

        public SendMoneyController(UserManager<AppUser> userManager, ICustomerAccountProcessService customerAccountProcessService)
        {
            _userManager = userManager;
            _customerAccountProcessService = customerAccountProcessService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(SendMoneyForCustomerAccountProcessDto sendMoneyForCustomerAccountProcessDto)
        {
            var context = new Context();
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var reciverAccountNumberID = context.CustomerAccounts.Where
                (x => x.CustomerAccountNumber == sendMoneyForCustomerAccountProcessDto.ReciverAccountNumber).Select
                (y => y.CustomerAccoundID).FirstOrDefault();

            var senderAccountNumberID = context.CustomerAccounts.Where(x => x.AppUserID == user.Id).Where(y => y.CustomerAccountCurrency 
            == "Türk Lıirası").Select(z => z.CustomerAccoundID).FirstOrDefault();

            // _customerAccountProcessService.TInsert();

            var values = new CustomerAccountProcess();
            values.ProcessDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            values.SenderID = senderAccountNumberID;
            values.ProcessType = "Havale";
            values.Amount = sendMoneyForCustomerAccountProcessDto.Amount;
            values.Description = sendMoneyForCustomerAccountProcessDto.Description;
              

            _customerAccountProcessService.TInsert(values);


            return RedirectToAction("Index", "Deneme");

            [HttpGet]
        }
    }
}

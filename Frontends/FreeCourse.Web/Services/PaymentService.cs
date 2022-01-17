using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeCourse.Web.Models.FakePayment;
using FreeCourse.Web.Services.Interface;

namespace FreeCourse.Web.Services
{
    public class PaymentService :IPaymentService
    {
        public async Task<bool> ReceivePayment(PaymentInfoInput paymentInfoInput)
        {
            throw new NotImplementedException();
        }
    }
}

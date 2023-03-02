using System.ComponentModel.DataAnnotations;

namespace POCTwilio.Models
{
    public class Sms
    {
        [Required(ErrorMessage = " O Code é obrigatório")]
        public string code { get; set; }
        [Required(ErrorMessage = " O Número  é obrigatório")]
        public string number { get; set; }


    }
}

using System.ComponentModel.DataAnnotations;

namespace Hotel.Atr.Saturday.Models
{
    //string name, string email, string message
    public class Message
    {
        [Required(ErrorMessage = "Поле name обязательно для заполнения")]
        public string name { get; set; }

        [Required(ErrorMessage = "Поле email обязательно для заполнения")]
        [EmailAddress(ErrorMessage = "email заполнен некорректно")]
        public string email { get; set; }

        public string message { get; set; }
    }
}
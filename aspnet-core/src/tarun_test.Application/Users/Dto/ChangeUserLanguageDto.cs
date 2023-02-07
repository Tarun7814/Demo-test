using System.ComponentModel.DataAnnotations;

namespace tarun_test.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CitizenPortal.Models
{
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class LanguageDictionaryViewModel 
    {
        public LanguageDictionaryViewModel()
        {
        }

        [HiddenInput]
        public long LanguageDictionaryId { get; set; }

        [HiddenInput]
        public long? ParentId { get; set; }

        [HiddenInput]
        public string LanguageDictionarySId { get; set; }

        [Required]
        [StringLength(50)]
        [Remote("IsLanguageKey_Available", "LanguageDictionary")]
        [RegularExpression("[a-zA-Z_]{2,50}", ErrorMessage = "${{OnlyCharNoSpace}}")]
        public string LanguageKey { get; set; }

        [Required]
        [StringLength(4000)]
        [RegularExpression("[a-zA-Z\\s\\d]{2,4000}", ErrorMessage = "${{OnlyCharNoSpace}}")]
        public string English { get; set; }

        [Required]
        [StringLength(4000)]
        [RegularExpression("[\\u0621-\\u064A\\u0660-\\u0669 0-9 ]{2,4000}", ErrorMessage = "${{ArabicOnly}}")]
        public string Arabic { get; set; }

        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
namespace CitizenPortal.Models
{
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class LanguageKeyViewModel
    {
        public string LanguageKey { get; set; }
        public string Englishk { get; set; }
        public string Arabick { get; set; }
    }
}

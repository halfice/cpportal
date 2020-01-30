using System.Collections.Generic;
using System.ComponentModel;
using Kendo.Mvc.UI;
using CitizenPortal.Models;
using CitizenPortal.DAL;

namespace CitizenPortal.Interfaces
{
    public interface ILanguageDictionaryService
    {
        List<LanguageKeyViewModel> GetDictionariesEN();
        List<LanguageKeyViewModel> GetDictionariesAR();
    }
}
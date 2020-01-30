using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using CitizenPortal.DAL;
using CitizenPortal.Interfaces;
using CitizenPortal.Models;

namespace CitizenPortal.Interfaces
{
    public class LanguageDictionaryService : ILanguageDictionaryService
    {
        List<LanguageKeyViewModel> Tempobject = null;
        List<LanguageKeyViewModel> LanguageObject = null;
        List<CPLanguageDictionary> LanguageObjectmos = null;
        public LanguageDictionaryService()
        {
            LanguageObject = new List<LanguageKeyViewModel>();
            using (var db = new dbContext())
            {
                LanguageObjectmos = db.CPLanguageDictionaries.ToList();
            }

           foreach(var Tempobject in LanguageObjectmos)
            {
               
                LanguageKeyViewModel singlex = new LanguageKeyViewModel();
                singlex.LanguageKey = Tempobject.LanguageKey;
                singlex.Englishk = Tempobject.English;
                singlex.Arabick = Tempobject.Arabic;
                LanguageObject.Add(singlex);

            }
        }

        public List<LanguageKeyViewModel> GetDictionariesEN()
        {

            LanguageObject = new List<LanguageKeyViewModel>();
            using (var db = new dbContext())
            {
                LanguageObjectmos = db.CPLanguageDictionaries.ToList();
            }

            foreach (var Tempobject in LanguageObjectmos)
            {

                LanguageKeyViewModel singlex = new LanguageKeyViewModel();
                singlex.LanguageKey = Tempobject.LanguageKey;
                singlex.Englishk = Tempobject.English;
                LanguageObject.Add(singlex);

            }
            return LanguageObject;
        }
        public List<LanguageKeyViewModel> GetDictionariesAR()
        {

            LanguageObject = new List<LanguageKeyViewModel>();
            using (var db = new dbContext())
            {
                LanguageObjectmos = db.CPLanguageDictionaries.ToList();
            }

            foreach (var Tempobject in LanguageObjectmos)
            {

                LanguageKeyViewModel singlex = new LanguageKeyViewModel();
                singlex.LanguageKey = Tempobject.LanguageKey;
                singlex.Arabick = Tempobject.Arabic;
                LanguageObject.Add(singlex);

            }
            return LanguageObject;
        }
    }
}

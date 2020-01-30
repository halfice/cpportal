using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitizenPortal.DAL;
using Kendo.Mvc.UI;

namespace CitizenPortal.Interfaces
{
    public interface IPortalService
    {
        bool RegisterUser(string UserName, string Password, string Email, string Name);

        CPUser LoginUser(string UserName, string Password);

        DataSourceResult GetGrid(DataSourceRequest request);
        DataSourceResult GetProfile(DataSourceRequest request ,string Title);
        
        List<CPLanguageDictionary> GetLanguageKeys();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitizenPortal.Interfaces;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System;
using Kendo.Mvc.Extensions;
using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using CitizenPortal.DAL;
using Kendo.Mvc.UI;

namespace CitizenPortal.Interfaces
{
    public class PortalService : IPortalService
    {
        public CPUser LoginUser(string UserName, string Password)
        {

            CPUser _user = new CPUser();
            using (var db = new dbContext())
            {
                _user = db.CPUsers.FirstOrDefault(x => x.EmailAddress == UserName);
                db.SaveChanges();
            }
            if (_user.EmailAddress != "")
            { return _user; }
            else
            {
                return null;
            }
        }

        public DataSourceResult GetGrid([DataSourceRequest] DataSourceRequest request)
        {
            using (var db = new dbContext())
            {
               var data =(db.dbDboProfilesGrid());
               return data.ToDataSourceResult(request);
            }
        }

        public List<CPLanguageDictionary> GetLanguageKeys( )
        {
            List<CPLanguageDictionary> obj = new List<CPLanguageDictionary>();
            using (var db = new dbContext())
            {
                obj = db.CPLanguageDictionaries.ToList();
                return obj;
            }
        }
        public DataSourceResult GetProfile([DataSourceRequest] DataSourceRequest request,string Title)
        {
            CPUser _user = new CPUser();
            using (var db = new dbContext())
            {
                var data = db.dbDboProfileUser(Title);
                return data.ToDataSourceResult(request);
            }
            
        }

        public bool RegisterUser(string UserName, string Email, string Password,  string Name)
        {
           
            CPUser _user = new CPUser();
            _user.UserSId = Guid.NewGuid().ToString() ;
            _user.UserName = UserName;
            _user.Password = Password;
            _user.EmailAddress = Email;
            _user.FullNameEn = Name;
            string temp = Regex.Replace(UserName, "[^0-9.]", "");
            long numberOnly = Convert.ToInt64(temp);
            _user.UserId = numberOnly;
            using (var db = new dbContext())
            {
                db.CPUsers.Add(_user);
                db.SaveChanges();
            }
            return true;
        }
    }
}

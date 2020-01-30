using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitizenPortal.Models
{
    public partial class ProfilesGridResult
    {
        public ProfilesGridResult()
        {
            OnCreated();
        }

        public virtual long UserId
        {
            get;
            set;
        }

        public virtual string UserSId
        {
            get;
            set;
        }

        public virtual System.Nullable<long> TenantId
        {
            get;
            set;
        }

        public virtual string UserName
        {
            get;
            set;
        }

        public virtual string Password
        {
            get;
            set;
        }

        public virtual string EmailAddress
        {
            get;
            set;
        }

        public virtual System.Nullable<int> EmployeeId
        {
            get;
            set;
        }

        public virtual string Title
        {
            get;
            set;
        }

        public virtual string FirstName
        {
            get;
            set;
        }

        public virtual string SecondName
        {
            get;
            set;
        }

        public virtual string ThirdName
        {
            get;
            set;
        }

        public virtual string LastName
        {
            get;
            set;
        }

        public virtual string FullNameEn
        {
            get;
            set;
        }

        public virtual string FullNameAr
        {
            get;
            set;
        }

        public virtual System.Nullable<bool> IsManager
        {
            get;
            set;
        }

        public virtual System.Nullable<long> ManagerId
        {
            get;
            set;
        }

        public virtual System.Nullable<int> OrgUnitId
        {
            get;
            set;
        }

        public virtual System.Nullable<int> OrgLv1Id
        {
            get;
            set;
        }

        public virtual System.Nullable<int> OrgLv2Id
        {
            get;
            set;
        }

        public virtual System.Nullable<int> OrgLv3Id
        {
            get;
            set;
        }

        public virtual System.Nullable<int> OrgLv4Id
        {
            get;
            set;
        }

        public virtual System.Nullable<int> OrgLv5Id
        {
            get;
            set;
        }

        public virtual System.Nullable<int> OrgLv6Id
        {
            get;
            set;
        }

        public virtual System.Nullable<int> OrgLv7Id
        {
            get;
            set;
        }

        public virtual System.Nullable<int> DesignationId
        {
            get;
            set;
        }

        public virtual string DesignationEn
        {
            get;
            set;
        }

        public virtual string DesignationAr
        {
            get;
            set;
        }

        public virtual System.Nullable<int> Grade
        {
            get;
            set;
        }

        public virtual string Gender
        {
            get;
            set;
        }

        public virtual System.Nullable<System.DateTime> DateOfBirth
        {
            get;
            set;
        }

        public virtual System.Nullable<int> NationalityId
        {
            get;
            set;
        }

        public virtual System.Nullable<System.DateTime> JoinedDate
        {
            get;
            set;
        }

        public virtual System.Nullable<System.DateTime> TerminationDate
        {
            get;
            set;
        }

        public virtual System.Nullable<bool> IsContractor
        {
            get;
            set;
        }

        public virtual System.Nullable<bool> IsArabic
        {
            get;
            set;
        }

        public virtual System.Nullable<bool> IsActive
        {
            get;
            set;
        }

        public virtual System.Nullable<bool> IsLocked
        {
            get;
            set;
        }

        public virtual System.Nullable<int> AccountType
        {
            get;
            set;
        }

        public virtual System.Nullable<System.DateTime> LastLoginDate
        {
            get;
            set;
        }

        public virtual System.Nullable<System.DateTime> CreationDate
        {
            get;
            set;
        }

        #region Extensibility Method Definitions

        partial void OnCreated();

        #endregion
    }
}

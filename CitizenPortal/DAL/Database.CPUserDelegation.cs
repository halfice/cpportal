﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 2020-01-29 02:52:35 PM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;

namespace CitizenPortal.DAL
{
    public partial class CPUserDelegation {

        public CPUserDelegation()
        {
            OnCreated();
        }

        public virtual long DelegationId
        {
            get;
            set;
        }

        public virtual long FromUserId
        {
            get;
            set;
        }

        public virtual long ToUserId
        {
            get;
            set;
        }

        public virtual System.DateTime FromDate
        {
            get;
            set;
        }

        public virtual System.Nullable<System.DateTime> ToDate
        {
            get;
            set;
        }

        public virtual string Comment
        {
            get;
            set;
        }

        public virtual long DelegatedRoleId
        {
            get;
            set;
        }

        public virtual string DelegationSId
        {
            get;
            set;
        }
    
        #region Extensibility Method Definitions

        partial void OnCreated();
        
        #endregion
    }

}

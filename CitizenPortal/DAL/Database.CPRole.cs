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
    public partial class CPRole {

        public CPRole()
        {
            this.CPGroupRoles = new List<CPGroupRole>();
            this.CPRoles_ParentId = new List<CPRole>();
            OnCreated();
        }

        public virtual long RoleId
        {
            get;
            set;
        }

        public virtual System.Nullable<long> ParentId
        {
            get;
            set;
        }

        public virtual string RoleSId
        {
            get;
            set;
        }

        public virtual string RoleName
        {
            get;
            set;
        }

        public virtual string RoleCode
        {
            get;
            set;
        }

        public virtual IList<CPGroupRole> CPGroupRoles
        {
            get;
            set;
        }

        public virtual IList<CPRole> CPRoles_ParentId
        {
            get;
            set;
        }

        public virtual CPRole CPRole_ParentId
        {
            get;
            set;
        }
    
        #region Extensibility Method Definitions

        partial void OnCreated();
        
        #endregion
    }

}

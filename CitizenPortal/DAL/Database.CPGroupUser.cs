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
    public partial class CPGroupUser {

        public CPGroupUser()
        {
            OnCreated();
        }

        public virtual long GroupId
        {
            get;
            set;
        }

        public virtual long UserId
        {
            get;
            set;
        }

        public virtual CPUser CPUser
        {
            get;
            set;
        }

        public virtual CPGroup CPGroup
        {
            get;
            set;
        }
    
        #region Extensibility Method Definitions

        partial void OnCreated();

        public override bool Equals(object obj)
        {
          CPGroupUser toCompare = obj as CPGroupUser;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.GroupId, toCompare.GroupId))
            return false;
          if (!Object.Equals(this.UserId, toCompare.UserId))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + GroupId.GetHashCode();
          hashCode = (hashCode * 7) + UserId.GetHashCode();
          return hashCode;
        }
        
        #endregion
    }

}

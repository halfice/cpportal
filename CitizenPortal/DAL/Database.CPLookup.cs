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
    public partial class CPLookup {

        public CPLookup()
        {
            OnCreated();
        }

        public virtual long LookupId
        {
            get;
            set;
        }

        public virtual long LookupCategoyId
        {
            get;
            set;
        }

        public virtual string LookupSId
        {
            get;
            set;
        }

        public virtual string EnglishName
        {
            get;
            set;
        }

        public virtual string ArabicName
        {
            get;
            set;
        }

        public virtual long OrderId
        {
            get;
            set;
        }

        public virtual System.Nullable<int> GroupBitWsie
        {
            get;
            set;
        }

        public virtual CPLookupCategory CPLookupCategory
        {
            get;
            set;
        }
    
        #region Extensibility Method Definitions

        partial void OnCreated();

        public override bool Equals(object obj)
        {
          CPLookup toCompare = obj as CPLookup;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.LookupId, toCompare.LookupId))
            return false;
          if (!Object.Equals(this.LookupCategoyId, toCompare.LookupCategoyId))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + LookupId.GetHashCode();
          hashCode = (hashCode * 7) + LookupCategoyId.GetHashCode();
          return hashCode;
        }
        
        #endregion
    }

}

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
    public partial class CPWFInstancesFollowup {

        public CPWFInstancesFollowup()
        {
            OnCreated();
        }

        public virtual long WfInstanceViewId
        {
            get;
            set;
        }

        public virtual long WFinstanceId
        {
            get;
            set;
        }

        public virtual long GroupId
        {
            get;
            set;
        }
    
        #region Extensibility Method Definitions

        partial void OnCreated();
        
        #endregion
    }

}

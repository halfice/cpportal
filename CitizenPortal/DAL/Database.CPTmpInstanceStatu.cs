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
    public partial class CPTmpInstanceStatu {

        public CPTmpInstanceStatu()
        {
            OnCreated();
        }

        public virtual int InstanceStatusId
        {
            get;
            set;
        }

        public virtual int InstanceId
        {
            get;
            set;
        }

        public virtual bool IsProcessed
        {
            get;
            set;
        }

        public virtual System.DateTime PauseToDate
        {
            get;
            set;
        }

        public virtual string StepId
        {
            get;
            set;
        }

        public virtual System.DateTime CreationDate
        {
            get;
            set;
        }

        public virtual CPTmpInstance CPTmpInstance
        {
            get;
            set;
        }
    
        #region Extensibility Method Definitions

        partial void OnCreated();
        
        #endregion
    }

}

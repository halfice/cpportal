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
    public partial class CPTmpInstance {

        public CPTmpInstance()
        {
            this.IsCompleted = false;
            this.IsClosed = false;
            this.CPTmpAssignees = new List<CPTmpAssignee>();
            this.CPTmpInstanceStatus = new List<CPTmpInstanceStatu>();
            OnCreated();
        }

        public virtual int InstanceId
        {
            get;
            set;
        }

        public virtual string InstanceKeyId
        {
            get;
            set;
        }

        public virtual int MetadataId
        {
            get;
            set;
        }

        public virtual string StepId
        {
            get;
            set;
        }

        public virtual string StepNameCaption
        {
            get;
            set;
        }

        public virtual string StepCaption
        {
            get;
            set;
        }

        public virtual string CycleId
        {
            get;
            set;
        }

        public virtual int RequesterId
        {
            get;
            set;
        }

        public virtual string BaseClass
        {
            get;
            set;
        }

        public virtual string Data
        {
            get;
            set;
        }

        public virtual bool IsCompleted
        {
            get;
            set;
        }

        public virtual bool IsClosed
        {
            get;
            set;
        }

        public virtual System.Nullable<System.DateTime> SLATimer
        {
            get;
            set;
        }

        public virtual System.DateTime CreationDate
        {
            get;
            set;
        }

        public virtual IList<CPTmpAssignee> CPTmpAssignees
        {
            get;
            set;
        }

        public virtual CPTmpMetadata CPTmpMetadata
        {
            get;
            set;
        }

        public virtual IList<CPTmpInstanceStatu> CPTmpInstanceStatus
        {
            get;
            set;
        }
    
        #region Extensibility Method Definitions

        partial void OnCreated();
        
        #endregion
    }

}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace cf.Module.BusinessObjects.ORMDataModel1
{

    public partial class Chamcong : DevExpress.Persistent.BaseImpl.BaseObject
    {
        Nhanvien fNhanvien_ID;
        [Association(@"ChamcongReferencesNhanvien")]
        public Nhanvien Nhanvien_ID
        {
            get { return fNhanvien_ID; }
            set { SetPropertyValue<Nhanvien>(nameof(Nhanvien_ID), ref fNhanvien_ID, value); }
        }
        string fGiovao;
        public string Giovao
        {
            get { return fGiovao; }
            set { SetPropertyValue<string>(nameof(Giovao), ref fGiovao, value); }
        }
        string fGiora;
        public string Giora
        {
            get { return fGiora; }
            set { SetPropertyValue<string>(nameof(Giora), ref fGiora, value); }
        }
    }

}
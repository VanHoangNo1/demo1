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

    public partial class Tieuhao : DevExpress.Persistent.BaseImpl.BaseObject
    {
        Sanpham fSanpham_ID;
        [Association(@"TieuhaoReferencesSanpham")]
        public Sanpham Sanpham_ID
        {
            get { return fSanpham_ID; }
            set { SetPropertyValue<Sanpham>(nameof(Sanpham_ID), ref fSanpham_ID, value); }
        }
        HoadonCT fHoadonCT_ID;
        [Association(@"TieuhaoReferencesHoadonCT")]
        public HoadonCT HoadonCT_ID
        {
            get { return fHoadonCT_ID; }
            set { SetPropertyValue<HoadonCT>(nameof(HoadonCT_ID), ref fHoadonCT_ID, value); }
        }
        string fSoluong;
        public string Soluong
        {
            get { return fSoluong; }
            set { SetPropertyValue<string>(nameof(Soluong), ref fSoluong, value); }
        }
        string fDongiaVon;
        public string DongiaVon
        {
            get { return fDongiaVon; }
            set { SetPropertyValue<string>(nameof(DongiaVon), ref fDongiaVon, value); }
        }
    }

}

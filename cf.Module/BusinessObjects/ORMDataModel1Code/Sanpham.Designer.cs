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

    [DefaultProperty("TenSP")]
    public partial class Sanpham : DevExpress.Persistent.BaseImpl.BaseObject
    {
        NhomSP fNhom_ID;
        [Association(@"SanphamReferencesNhomSP")]
        public NhomSP Nhom_ID
        {
            get { return fNhom_ID; }
            set { SetPropertyValue<NhomSP>(nameof(Nhom_ID), ref fNhom_ID, value); }
        }
        string fTenSp;
        public string TenSp
        {
            get { return fTenSp; }
            set { SetPropertyValue<string>(nameof(TenSp), ref fTenSp, value); }
        }
        string fDvt;
        public string Dvt
        {
            get { return fDvt; }
            set { SetPropertyValue<string>(nameof(Dvt), ref fDvt, value); }
        }
        decimal fGiaban;
        public decimal Giaban
        {
            get { return fGiaban; }
            set { SetPropertyValue<decimal>(nameof(Giaban), ref fGiaban, value); }
        }
        [Association(@"HoadonCTReferencesSanpham"), Aggregated]
        public XPCollection<HoadonCT> HoadonCTs { get { return GetCollection<HoadonCT>(nameof(HoadonCTs)); } }
        [Association(@"DinhluongReferencesSanpham"), Aggregated]
        public XPCollection<Dinhluong> Dinhluongs { get { return GetCollection<Dinhluong>(nameof(Dinhluongs)); } }
        [Association(@"DinhluongReferencesSanpham1"), Aggregated]
        public XPCollection<Dinhluong> Dinhluongs1 { get { return GetCollection<Dinhluong>(nameof(Dinhluongs1)); } }
        [Association(@"TieuhaoReferencesSanpham"), Aggregated]
        public XPCollection<Tieuhao> Tieuhaos { get { return GetCollection<Tieuhao>(nameof(Tieuhaos)); } }
        [Association(@"DongnhapReferencesSanpham"), Aggregated]
        public XPCollection<Dongnhap> Dongnhaps { get { return GetCollection<Dongnhap>(nameof(Dongnhaps)); } }
    }

}
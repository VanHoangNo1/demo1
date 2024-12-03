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

    public partial class Phieunhap : DevExpress.Persistent.BaseImpl.BaseObject
    {
        Nhacungcap fNCC_ID;
        [Association(@"PhieunhapReferencesNhacungcap")]
        public Nhacungcap NCC_ID
        {
            get { return fNCC_ID; }
            set { SetPropertyValue<Nhacungcap>(nameof(NCC_ID), ref fNCC_ID, value); }
        }
        Nhanvien fNhanvien_ID;
        [Association(@"PhieunhapReferencesNhanvien")]
        public Nhanvien Nhanvien_ID
        {
            get { return fNhanvien_ID; }
            set { SetPropertyValue<Nhanvien>(nameof(Nhanvien_ID), ref fNhanvien_ID, value); }
        }
        string fSo;
        public string So
        {
            get { return fSo; }
            set { SetPropertyValue<string>(nameof(So), ref fSo, value); }
        }
        DateTime fNgay;
        [DevExpress.ExpressApp.Model.ModelDefault("EditMask", "dd/MM/yyyy HH:mm"),
DevExpress.ExpressApp.Model.ModelDefault("DisplayFormat", "{0:dd/MM/yyyy HH:mm}")]
        public DateTime Ngay
        {
            get { return fNgay; }
            set { SetPropertyValue<DateTime>(nameof(Ngay), ref fNgay, value); }
        }
        [Association(@"DongnhapReferencesPhieunhap"), Aggregated]
        public XPCollection<Dongnhap> Dongnhaps { get { return GetCollection<Dongnhap>(nameof(Dongnhaps)); } }
    }

}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BTLWEB2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SaleShoesEntities2 : DbContext
    {
        public SaleShoesEntities2()
            : base("name=SaleShoesEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tChiTietGioHang> tChiTietGioHangs { get; set; }
        public virtual DbSet<tChiTietHoaDon> tChiTietHoaDons { get; set; }
        public virtual DbSet<tGioHang> tGioHangs { get; set; }
        public virtual DbSet<tHoaDon> tHoaDons { get; set; }
        public virtual DbSet<tSanPham> tSanPhams { get; set; }
        public virtual DbSet<tTaiKhoan> tTaiKhoans { get; set; }
        public virtual DbSet<CartView> CartViews { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DentalClinic2.m
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DB_dentist_clinicEntities : DbContext
    {
        public DB_dentist_clinicEntities()
            : base("name=DB_dentist_clinicEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TBL_Appointment> TBL_Appointment { get; set; }
        public virtual DbSet<TBL_ClinicDateTable> TBL_ClinicDateTable { get; set; }
        public virtual DbSet<TBL_DentistType> TBL_DentistType { get; set; }
        public virtual DbSet<TBL_desntistsWorkTime> TBL_desntistsWorkTime { get; set; }
        public virtual DbSet<TBL_doctors> TBL_doctors { get; set; }
        public virtual DbSet<TBL_Entrance> TBL_Entrance { get; set; }
        public virtual DbSet<TBL_Patients> TBL_Patients { get; set; }
        public virtual DbSet<TBL_RoleType> TBL_RoleType { get; set; }
        public virtual DbSet<TBL_Sections> TBL_Sections { get; set; }
        public virtual DbSet<TBL_Services> TBL_Services { get; set; }
        public virtual DbSet<TBL_Users> TBL_Users { get; set; }
        public virtual DbSet<Vw_DentistsWorkTime> Vw_DentistsWorkTime { get; set; }
        public virtual DbSet<TBL_Images> TBL_Images { get; set; }
        public virtual DbSet<DoctorWorkTimeVW> DoctorWorkTimeVWs { get; set; }
        public virtual DbSet<AppointmentVW> AppointmentVWs { get; set; }
        public virtual DbSet<FinancialVW1> FinancialVW1 { get; set; }
    
        public virtual int del_DocByID(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("del_DocByID", iDParameter);
        }
    
        public virtual int del_docId(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("del_docId", iDParameter);
        }
    
        public virtual int del_PatByID(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("del_PatByID", iDParameter);
        }
    
        public virtual int del_PatientById(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("del_PatientById", iDParameter);
        }
    
        public virtual int del_PersonelByID(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("del_PersonelByID", iDParameter);
        }
    
        public virtual ObjectResult<PatientsAppointments_Result> PatientsAppointments()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PatientsAppointments_Result>("PatientsAppointments");
        }
    
        public virtual ObjectResult<Appointments1_Result> Appointments1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Appointments1_Result>("Appointments1");
        }
    
        public virtual int del_ImgById(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("del_ImgById", iDParameter);
        }
    
        public virtual int del_apById(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("del_apById", iDParameter);
        }
    
        public virtual int UpdateAppointment(Nullable<int> appointmentID, string newDataColumn1, Nullable<int> newDataColumn2)
        {
            var appointmentIDParameter = appointmentID.HasValue ?
                new ObjectParameter("AppointmentID", appointmentID) :
                new ObjectParameter("AppointmentID", typeof(int));
    
            var newDataColumn1Parameter = newDataColumn1 != null ?
                new ObjectParameter("NewDataColumn1", newDataColumn1) :
                new ObjectParameter("NewDataColumn1", typeof(string));
    
            var newDataColumn2Parameter = newDataColumn2.HasValue ?
                new ObjectParameter("NewDataColumn2", newDataColumn2) :
                new ObjectParameter("NewDataColumn2", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateAppointment", appointmentIDParameter, newDataColumn1Parameter, newDataColumn2Parameter);
        }
    }
}
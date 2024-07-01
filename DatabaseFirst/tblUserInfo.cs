//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblUserInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblUserInfo()
        {
            this.tblZayavkaChat = new HashSet<tblZayavkaChat>();
            this.tblLog = new HashSet<tblLog>();
            this.tblESignDoc = new HashSet<tblESignDoc>();
            this.tblGP_Predstavitel = new HashSet<tblGP_Predstavitel>();
            this.tblZayavkaDoc = new HashSet<tblZayavkaDoc>();
            this.tblZayavka = new HashSet<tblZayavka>();
        }
    
        public System.DateTime date_create_user { get; set; }
        public System.Guid id_user { get; set; }
        public string fl_familiya { get; set; }
        public string fl_name { get; set; }
        public string fl_otchestvo { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
        public string yl_fullname { get; set; }
        public string yl_shortname { get; set; }
        public string inn { get; set; }
        public string contact_familiya { get; set; }
        public string contact_name { get; set; }
        public string contact_otchestvo { get; set; }
        public string confirm_code { get; set; }
        public Nullable<System.DateTime> confirm_code_date_send { get; set; }
        public string comment { get; set; }
        public int id_usertype { get; set; }
        public int id_userrole { get; set; }
        public string password_text { get; set; }
        public string user_login { get; set; }
        public string user_nameingrid { get; set; }
        public int id_filial { get; set; }
        public Nullable<System.Guid> id_registration_typeid { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public Nullable<bool> IsLockedOut { get; set; }
    
        public virtual tblUserType tblUserType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblZayavkaChat> tblZayavkaChat { get; set; }
        public virtual tblUserRole tblUserRole { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblLog> tblLog { get; set; }
        public virtual tblFilial tblFilial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblESignDoc> tblESignDoc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblGP_Predstavitel> tblGP_Predstavitel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblZayavkaDoc> tblZayavkaDoc { get; set; }
        public virtual tblUserRegistrationType tblUserRegistrationType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblZayavka> tblZayavka { get; set; }
    }
}

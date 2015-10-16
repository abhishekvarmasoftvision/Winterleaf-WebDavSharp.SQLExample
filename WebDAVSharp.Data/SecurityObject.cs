//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebDAVSharp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class SecurityObject
    {
        internal SecurityObject()
        {
            this.SecurityObjectPermissions = new HashSet<SecurityObjectPermission>();
            this.ObjectLockInfoes = new HashSet<ObjectLockInfo>();
            this.Files = new HashSet<File>();
            this.Folders = new HashSet<Folder>();
            this.Files1 = new HashSet<File>();
            this.Folders1 = new HashSet<Folder>();
            this.FileSecurities = new HashSet<FileSecurity>();
            this.FolderSecurities = new HashSet<FolderSecurity>();
            this.MyGroups = new HashSet<SecurityObjectMembership>();
            this.MyMembers = new HashSet<SecurityObjectMembership>();
            this.Files2 = new HashSet<File>();
            this.Folders2 = new HashSet<Folder>();
        }
    
        public System.Guid SecurityObjectId { get; private set; }
        public Nullable<System.Guid> ActiveDirectoryId { get; internal set; }
        public string FullName { get; internal set; }
        public string Username { get; internal set; }
        public string EmailAddress { get; internal set; }
        public bool IsGroup { get; internal set; }
        public Nullable<System.DateTime> LastLogInOn { get; set; }
        public bool IsActive { get; internal set; }
        public Nullable<System.Guid> HomeFolder { get; internal set; }
    
        public virtual ICollection<SecurityObjectPermission> SecurityObjectPermissions { get; set; }
        public virtual ICollection<ObjectLockInfo> ObjectLockInfoes { get; set; }
        public virtual ICollection<File> Files { get; set; }
        public virtual ICollection<Folder> Folders { get; set; }
        public virtual ICollection<File> Files1 { get; set; }
        public virtual ICollection<Folder> Folders1 { get; set; }
        public virtual Folder Folder { get; set; }
        public virtual ICollection<FileSecurity> FileSecurities { get; set; }
        public virtual ICollection<FolderSecurity> FolderSecurities { get; set; }
        internal virtual ICollection<SecurityObjectMembership> MyGroups { get; set; }
        internal virtual ICollection<SecurityObjectMembership> MyMembers { get; set; }
        public virtual ICollection<File> Files2 { get; set; }
        public virtual ICollection<Folder> Folders2 { get; set; }
    }
}
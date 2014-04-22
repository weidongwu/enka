//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rotterdam.Data.Sql.EntityFramework.Static
{
    using System;
    using System.Collections.Generic;
    
    public partial class ManagedType
    {
        public ManagedType()
        {
            this.DataspaceHierarchyMappings = new HashSet<DataspaceHierarchyMapping>();
            this.DataspaceTypeMappings = new HashSet<DataspaceTypeMapping>();
            this.ManagedEntities = new HashSet<ManagedEntity>();
            this.ManagedTypeProperties = new HashSet<ManagedTypeProperty>();
        }
    
        public System.Guid ManagedTypeId { get; set; }
        public string ManagedTypeTableName { get; set; }
        public string ManagedTypeViewName { get; set; }
        public string Name { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateModified { get; set; }
        public bool IsAbstract { get; set; }
        public bool IsSingleton { get; set; }
        public bool IsExtension { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual ICollection<DataspaceHierarchyMapping> DataspaceHierarchyMappings { get; set; }
        public virtual ICollection<DataspaceTypeMapping> DataspaceTypeMappings { get; set; }
        public virtual ICollection<ManagedEntity> ManagedEntities { get; set; }
        public virtual ICollection<ManagedTypeProperty> ManagedTypeProperties { get; set; }
    }
}

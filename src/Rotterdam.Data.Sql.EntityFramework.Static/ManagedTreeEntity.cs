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
    
    public partial class ManagedTreeEntity
    {
        public System.Guid ManagedTreeEntityId { get; set; }
        public System.Guid ManagedTreeId { get; set; }
        public System.Guid ManagedEntityId { get; set; }
        public Nullable<System.Guid> ManagedTreeEntityParentId { get; set; }
    
        public virtual ManagedEntity ManagedEntity { get; set; }
        public virtual ManagedTree ManagedTree { get; set; }
        public virtual ManagedTreeEntity ManagedTreeEntity1 { get; set; }
        public virtual ManagedTreeEntity ManagedTreeEntity2 { get; set; }
    }
}
using N2.Entity.MappingConfiguration;
using N2.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace N2.Entity.MappingConfiguration
{
    public class Sys_WorkFlowTableAuditLogMapConfig : EntityMappingConfiguration<Sys_WorkFlowTableAuditLog>
    {
        public override void Map(EntityTypeBuilder<Sys_WorkFlowTableAuditLog>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}


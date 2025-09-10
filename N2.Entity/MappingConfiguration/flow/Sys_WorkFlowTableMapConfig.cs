using N2.Entity.MappingConfiguration;
using N2.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace N2.Entity.MappingConfiguration
{
    public class Sys_WorkFlowTableMapConfig : EntityMappingConfiguration<Sys_WorkFlowTable>
    {
        public override void Map(EntityTypeBuilder<Sys_WorkFlowTable>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}


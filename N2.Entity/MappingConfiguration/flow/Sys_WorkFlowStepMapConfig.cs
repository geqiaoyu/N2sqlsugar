using N2.Entity.MappingConfiguration;
using N2.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace N2.Entity.MappingConfiguration
{
    public class Sys_WorkFlowStepMapConfig : EntityMappingConfiguration<Sys_WorkFlowStep>
    {
        public override void Map(EntityTypeBuilder<Sys_WorkFlowStep>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}


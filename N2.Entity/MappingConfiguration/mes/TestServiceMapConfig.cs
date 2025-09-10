using N2.Entity.MappingConfiguration;
using N2.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace N2.Entity.MappingConfiguration
{
    public class TestServiceMapConfig : EntityMappingConfiguration<TestService>
    {
        public override void Map(EntityTypeBuilder<TestService>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}


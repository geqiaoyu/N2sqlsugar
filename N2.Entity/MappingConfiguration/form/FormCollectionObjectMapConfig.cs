using N2.Entity.MappingConfiguration;
using N2.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace N2.Entity.MappingConfiguration
{
    public class FormCollectionObjectMapConfig : EntityMappingConfiguration<FormCollectionObject>
    {
        public override void Map(EntityTypeBuilder<FormCollectionObject>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}


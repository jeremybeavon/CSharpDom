using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StaticClassFieldCollectionWithMonoCecil :
        AbstractStaticClassFieldCollection<StaticClassFieldWithMonoCecil, StaticClassConstantWithMonoCecil>
    {
        private readonly StaticTypeWithMonoCecil typeWithMonoCecil;

        internal StaticClassFieldCollectionWithMonoCecil(StaticTypeWithMonoCecil typeWithMonoCecil)
        {
            this.typeWithMonoCecil = typeWithMonoCecil;
        }
        
        public override IReadOnlyCollection<StaticClassConstantWithMonoCecil> Constants
        {
            get { return typeWithMonoCecil.FieldCollection.Fields.ConstantsWithMonoCecil; }
        }

        protected override IReadOnlyCollection<StaticClassFieldWithMonoCecil> Fields
        {
            get { return typeWithMonoCecil.FieldCollection.Fields.FieldsWithMonoCecil; }
        }
    }
}

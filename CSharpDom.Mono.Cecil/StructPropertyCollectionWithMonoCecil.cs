using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StructPropertyCollectionWithMonoCecil :
        AbstractStructPropertyCollection<StructPropertyWithMonoCecil, ExplicitInterfacePropertyWithMonoCecil>
    {
        private readonly StructTypeWithMonoCecil typeWithMonoCecil;

        internal StructPropertyCollectionWithMonoCecil(StructTypeWithMonoCecil typeWithMonoCecil)
        {
            this.typeWithMonoCecil = typeWithMonoCecil;
        }

        public override IReadOnlyCollection<ExplicitInterfacePropertyWithMonoCecil> ExplicitInterfaceProperties
        {
            get { return typeWithMonoCecil.PropertyCollection.Properties.ExplicitInterfacePropertiesWithMonoCecil; }
        }

        protected override IReadOnlyCollection<StructPropertyWithMonoCecil> Properties
        {
            get { return typeWithMonoCecil.PropertyCollection.Properties.PropertiesWithMonoCecil; }
        }
    }
}

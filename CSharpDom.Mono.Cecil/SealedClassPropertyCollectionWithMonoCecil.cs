using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class SealedClassPropertyCollectionWithMonoCecil :
        AbstractSealedClassPropertyCollection<
            SealedClassPropertyWithMonoCecil,
            ExplicitInterfacePropertyWithMonoCecil>
    {
        private readonly SealedTypeWithMonoCecil typeWithMonoCecil;

        internal SealedClassPropertyCollectionWithMonoCecil(SealedTypeWithMonoCecil typeWithMonoCecil)
        {
            this.typeWithMonoCecil = typeWithMonoCecil;
        }
        
        public override IReadOnlyCollection<ExplicitInterfacePropertyWithMonoCecil> ExplicitInterfaceProperties
        {
            get { return typeWithMonoCecil.PropertyCollection.Properties.ExplicitInterfacePropertiesWithMonoCecil; }
        }

        protected override IReadOnlyCollection<SealedClassPropertyWithMonoCecil> Properties
        {
            get { return typeWithMonoCecil.PropertyCollection.Properties.PropertiesWithMonoCecil; }
        }
    }
}

using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ClassPropertyCollectionWithMonoCecil :
        AbstractClassPropertyCollection<ClassPropertyWithMonoCecil, ExplicitInterfacePropertyWithMonoCecil>
    {
        private readonly ClassTypeWithMonoCecil typeWithMonoCecil;

        internal ClassPropertyCollectionWithMonoCecil(ClassTypeWithMonoCecil typeWithMonoCecil)
        {
            this.typeWithMonoCecil = typeWithMonoCecil;
        }

        public override IReadOnlyCollection<ExplicitInterfacePropertyWithMonoCecil> ExplicitInterfaceProperties
        {
            get { return typeWithMonoCecil.PropertyCollection.Properties.ExplicitInterfacePropertiesWithMonoCecil; }
        }

        protected override IReadOnlyCollection<ClassPropertyWithMonoCecil> Properties
        {
            get { return typeWithMonoCecil.PropertyCollection.Properties.PropertiesWithMonoCecil; }
        }
    }
}

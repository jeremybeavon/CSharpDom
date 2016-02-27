using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class AbstractClassPropertyCollectionWithMonoCecil :
        AbstractAbstractClassPropertyCollection<
            ClassPropertyWithMonoCecil,
            AbstractPropertyWithMonoCecil,
            ExplicitInterfacePropertyWithMonoCecil>
    {
        private readonly ClassTypeWithMonoCecil typeWithMonoCecil;

        internal AbstractClassPropertyCollectionWithMonoCecil(ClassTypeWithMonoCecil typeWithMonoCecil)
        {
            this.typeWithMonoCecil = typeWithMonoCecil;
        }

        public override IReadOnlyCollection<AbstractPropertyWithMonoCecil> AbstractProperties
        {
            get { return typeWithMonoCecil.PropertyCollection.Properties.AbstractPropertiesWithMonoCecil; }
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

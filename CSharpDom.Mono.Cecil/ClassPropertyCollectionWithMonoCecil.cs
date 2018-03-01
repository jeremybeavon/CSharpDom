using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using CSharpDom.NotSupported;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ClassPropertyCollectionWithMonoCecil :
        AbstractClassPropertyCollection<
            ClassPropertyWithMonoCecil,
            PropertyNotSupported,
            PropertyNotSupported,
            ExplicitInterfacePropertyWithMonoCecil>
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

        public override IReadOnlyCollection<PropertyNotSupported> AutoProperties => new PropertyNotSupported[0];

        public override IReadOnlyCollection<PropertyNotSupported> LambdaProperties => new PropertyNotSupported[0];

        protected override IReadOnlyCollection<ClassPropertyWithMonoCecil> Properties
        {
            get { return typeWithMonoCecil.PropertyCollection.Properties.PropertiesWithMonoCecil; }
        }
    }
}

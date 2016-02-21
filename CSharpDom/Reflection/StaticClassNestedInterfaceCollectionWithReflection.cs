using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class StaticClassNestedInterfaceCollectionWithReflection :
        AbstractStaticClassNestedInterfaceCollection<StaticClassNestedInterfaceWithReflection, PartialInterfaceNotSupported>
    {
        private readonly StaticTypeWithReflection typeWithReflection;

        internal StaticClassNestedInterfaceCollectionWithReflection(StaticTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }

        public override IReadOnlyCollection<PartialInterfaceNotSupported> PartialInterfaces
        {
            get { return new PartialInterfaceNotSupported[0]; }
        }

        protected override IReadOnlyCollection<StaticClassNestedInterfaceWithReflection> Interfaces
        {
            get { return typeWithReflection.NestedTypeCollection.NestedTypes.NestedInterfaces; }
        }
    }
}

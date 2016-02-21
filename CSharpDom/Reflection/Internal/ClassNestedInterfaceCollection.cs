using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class ClassNestedInterfaceCollection : AbstractClassNestedInterfaceCollection
    {
        private readonly ClassTypeWithReflection typeWithReflection;

        internal ClassNestedInterfaceCollection(ClassTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }
        
        protected override IReadOnlyCollection<ClassNestedInterfaceWithReflection> Interfaces
        {
            get { return typeWithReflection.NestedTypeCollection.NestedTypes.NestedInterfaces; }
        }
    }
}

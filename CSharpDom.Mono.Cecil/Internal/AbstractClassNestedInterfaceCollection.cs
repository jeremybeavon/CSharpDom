using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal abstract class AbstractClassNestedInterfaceCollection :
        AbstractClassNestedInterfaceCollection<ClassNestedInterfaceWithMonoCecil, PartialInterfaceNotSupported>
    {
        public sealed override IReadOnlyCollection<PartialInterfaceNotSupported> PartialInterfaces
        {
            get { return new PartialInterfaceNotSupported[0]; }
        }
    }
}

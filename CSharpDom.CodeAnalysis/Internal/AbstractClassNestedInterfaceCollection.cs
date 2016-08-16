using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal abstract class AbstractClassNestedInterfaceCollection :
        AbstractClassNestedInterfaceCollection<ClassNestedInterfaceWithCodeAnalysis, PartialInterfaceNotSupported>
    {
        public sealed override IReadOnlyCollection<PartialInterfaceNotSupported> PartialInterfaces
        {
            get { return new PartialInterfaceNotSupported[0]; }
        }
    }
}

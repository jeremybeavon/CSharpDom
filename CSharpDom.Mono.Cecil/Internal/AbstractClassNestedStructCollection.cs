using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal abstract class AbstractClassNestedStructCollection :
        AbstractClassNestedStructCollection<ClassNestedStructWithMonoCecil, PartialStructNotSupported>
    {
        public sealed override IReadOnlyCollection<PartialStructNotSupported> PartialStructs
        {
            get { return new PartialStructNotSupported[0]; }
        }
    }
}

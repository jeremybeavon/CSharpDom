using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;

namespace CSharpDom.Reflection.Internal
{
    internal abstract class AbstractClassNestedStructCollection :
        AbstractClassNestedStructCollection<ClassNestedStructWithReflection, PartialStructNotSupported>
    {
        public sealed override IReadOnlyCollection<PartialStructNotSupported> PartialStructs
        {
            get { return new PartialStructNotSupported[0]; }
        }
    }
}

using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal abstract class AbstractClassNestedStructCollection :
        AbstractClassNestedStructCollection<ClassNestedStructWithCodeAnalysis, PartialStructNotSupported>
    {
        public sealed override IReadOnlyCollection<PartialStructNotSupported> PartialStructs
        {
            get { return new PartialStructNotSupported[0]; }
        }
    }
}

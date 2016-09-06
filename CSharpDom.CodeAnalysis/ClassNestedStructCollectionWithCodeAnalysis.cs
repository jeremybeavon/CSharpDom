using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using CSharpDom.NotSupported.Partial;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassNestedStructCollectionWithCodeAnalysis :
        EditableClassNestedStructCollection<IClassNestedStruct, PartialStructNotSupported>
    {
        private readonly ClassTypeWithCodeAnalysis classType;

        internal ClassNestedStructCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis classType)
        {
            this.classType = classType;
        }
    }
}

using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using CSharpDom.NotSupported.Partial;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructNestedStructCollectionWithCodeAnalysis :
        EditableStructNestedStructCollection<IStructNestedStruct, PartialStructNotSupported>
    {
        private readonly StructTypeWithCodeAnalysis structType;

        internal StructNestedStructCollectionWithCodeAnalysis(StructTypeWithCodeAnalysis structType)
        {
            this.structType = structType;
        }
    }
}

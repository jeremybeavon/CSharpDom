using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using CSharpDom.NotSupported;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructNestedClassCollectionWithCodeAnalysis :
        EditableStructNestedClassCollection<
            IStructNestedClass,
            IStructNestedAbstractClass,
            IStructNestedSealedClass,
            IStructNestedStaticClass,
            PartialClassCollectionNotSupported>
    {
        private readonly StructTypeWithCodeAnalysis structType;

        internal StructNestedClassCollectionWithCodeAnalysis(StructTypeWithCodeAnalysis structType)
        {
            this.structType = structType;
        }
    }
}

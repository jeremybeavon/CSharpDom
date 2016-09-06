using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using CSharpDom.NotSupported.Partial;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassNestedStructCollectionWithCodeAnalysis :
        EditableStaticClassNestedStructCollection<IStaticClassNestedStruct, PartialStructNotSupported>
    {
        private readonly StaticTypeWithCodeAnalysis type;

        internal StaticClassNestedStructCollectionWithCodeAnalysis(StaticTypeWithCodeAnalysis type)
        {
            this.type = type;
        }
    }
}

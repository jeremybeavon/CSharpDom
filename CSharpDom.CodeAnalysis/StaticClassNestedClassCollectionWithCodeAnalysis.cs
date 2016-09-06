using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using CSharpDom.NotSupported;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassNestedClassCollectionWithCodeAnalysis :
        EditableStaticClassNestedClassCollection<
            IStaticClassNestedClass,
            IStaticClassNestedAbstractClass,
            IStaticClassNestedSealedClass,
            IStaticClassNestedStaticClass,
            PartialClassCollectionNotSupported>
    {
        private readonly StaticTypeWithCodeAnalysis type;

        internal StaticClassNestedClassCollectionWithCodeAnalysis(StaticTypeWithCodeAnalysis type)
        {
            this.type = type;
        }
    }
}

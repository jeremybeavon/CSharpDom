﻿using CSharpDom.Editable;
using CSharpDom.CodeAnalysis.Partial;

namespace CSharpDom.CodeAnalysis
{
    public abstract class StaticClassNestedStructCollectionWithCodeAnalysis :
        EditableStaticClassNestedStructCollection<
            StaticClassNestedStructWithCodeAnalysis,
            StaticClassNestedPartialStructWithCodeAnalysis>
    {
    }
}

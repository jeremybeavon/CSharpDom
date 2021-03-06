﻿using CSharpDom.BaseClasses.Editable;
using CSharpDom.CodeAnalysis.Partial;

namespace CSharpDom.CodeAnalysis
{
    public abstract class StructNestedStructCollectionWithCodeAnalysis :
        EditableStructNestedStructCollection<StructNestedStructWithCodeAnalysis, StructNestedPartialStructWithCodeAnalysis>
    {
    }
}

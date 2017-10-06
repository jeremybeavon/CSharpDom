using CSharpDom.BaseClasses.Editable;
using CSharpDom.CodeAnalysis.Partial;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public abstract class StaticClassNestedStructCollectionWithCodeAnalysis :
        EditableStaticClassNestedStructCollection<
            StaticClassNestedStructWithCodeAnalysis,
            StaticClassNestedPartialStructWithCodeAnalysis>
    {
    }
}

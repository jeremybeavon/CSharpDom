using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public abstract class StaticClassEventCollectionWithCodeAnalysis :
        EditableStaticClassEventCollection<
            StaticClassEventWithCodeAnalysis,
            StaticClassEventPropertyWithCodeAnalysis>
    {
    }
}

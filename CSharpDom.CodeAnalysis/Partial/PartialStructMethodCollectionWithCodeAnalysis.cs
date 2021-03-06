﻿using CSharpDom.BaseClasses.Editable.Partial;

namespace CSharpDom.CodeAnalysis.Partial
{
    public abstract class PartialStructMethodCollectionWithCodeAnalysis :
        EditablePartialStructMethodCollection<
            StructMethodWithCodeAnalysis,
            ExplicitInterfaceMethodWithCodeAnalysis,
            PartialMethodDefinitionWithCodeAnalysis,
            PartialMethodImplementationWithCodeAnalysis>
    {
    }
}

﻿using CSharpDom.BaseClasses.Editable;

namespace CSharpDom.CodeAnalysis
{
    public abstract class ClassPropertyCollectionWithCodeAnalysis :
        EditableClassPropertyCollection<
            ClassPropertyWithCodeAnalysis,
            ClassAutoPropertyWithCodeAnalysis,
            ClassLambdaPropertyWithCodeAnalysis,
            ExplicitInterfacePropertyWithCodeAnalysis>
    {
    }
}

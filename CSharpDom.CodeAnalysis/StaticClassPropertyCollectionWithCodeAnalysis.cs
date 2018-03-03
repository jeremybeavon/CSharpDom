﻿using CSharpDom.BaseClasses.Editable;

namespace CSharpDom.CodeAnalysis
{
    public abstract class StaticClassPropertyCollectionWithCodeAnalysis :
        EditableStaticClassPropertyCollection<
            StaticClassPropertyWithCodeAnalysis,
            StaticClassAutoPropertyWithCodeAnalysis,
            StaticClassLambdaPropertyWithCodeAnalysis>
    {
    }
}

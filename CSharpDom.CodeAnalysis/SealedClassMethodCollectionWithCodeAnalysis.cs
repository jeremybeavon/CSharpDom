﻿using CSharpDom.BaseClasses.Editable;

namespace CSharpDom.CodeAnalysis
{
    public abstract class SealedClassMethodCollectionWithCodeAnalysis :
        EditableSealedClassMethodCollection<
            SealedClassMethodWithCodeAnalysis,
            ExplicitInterfaceMethodWithCodeAnalysis>
    {
    }
}

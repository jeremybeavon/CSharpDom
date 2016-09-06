using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using CSharpDom.NotSupported;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassNestedClassCollectionWithCodeAnalysis :
        EditableClassNestedClassCollection<
            IClassNestedClass,
            IClassNestedAbstractClass,
            IClassNestedSealedClass,
            IClassNestedStaticClass,
            PartialClassCollectionNotSupported>
    {
        private readonly ClassTypeWithCodeAnalysis classType;

        internal ClassNestedClassCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis classType)
        {
            this.classType = classType;
        }
    }
}

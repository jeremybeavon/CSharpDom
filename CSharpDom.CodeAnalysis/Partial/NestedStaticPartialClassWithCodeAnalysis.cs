using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.Partial
{
    internal sealed class NestedStaticPartialClassWithCodeAnalysis<TClass> :
        EditableNestedStaticClass<
            AttributeGroupWithCodeAnalysis,
            IType,
            GenericParameterDeclarationWithCodeAnalysis,
            NestedStaticPartialClassEventCollectionWithCodeAnalysis,
            NestedStaticPartialClassPropertyWithCodeAnalysis,
            NestedStaticPartialClassMethodCollectionWithCodeAnalysis,
            NestedStaticPartialClassFieldCollectionWithCodeAnalysis,
            NestedStaticPartialClassNestedClassCollectionWithCodeAnalysis,
            NestedStaticPartialClassNestedDelegateWithCodeAnalysis,
            NestedStaticPartialClassNestedEnumWithCodeAnalysis,
            NestedStaticPartialClassNestedInterfaceWithCodeAnalysis,
            NestedStaticPartialClassNestedStructCollectionWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>
        where TClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalNestedStaticClassWithCodeAnalysis<TClass> classType;
        private readonly NestedStaticPartialClassNestedClassCollectionWithCodeAnalysis classes;

        internal NestedStaticPartialClassWithCodeAnalysis(InternalNestedStaticClassWithCodeAnalysis<TClass> classType)
        {
            this.classType = classType;
            classes = new 
        }

    }
}

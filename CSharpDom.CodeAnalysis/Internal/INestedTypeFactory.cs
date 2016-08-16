using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal interface INestedTypeFactory<
        TNestedAbstractClass,
        TNestedClass,
        TNestedSealedClass,
        TNestedStaticClass,
        TNestedDelegate,
        TNestedEnum,
        TNestedInterface,
        TNestedStruct>
    {
        TNestedAbstractClass CreateNestedAbstractClass(ITypeWithCodeAnalysis declaringType, TypeDefinition type);

        TNestedClass CreateNestedClass(ITypeWithCodeAnalysis declaringType, TypeDefinition type);

        TNestedSealedClass CreateNestedSealedClass(ITypeWithCodeAnalysis declaringType, TypeDefinition type);

        TNestedStaticClass CreateNestedStaticClass(ITypeWithCodeAnalysis declaringType, TypeDefinition type);

        TNestedDelegate CreateNestedDelegate(ITypeWithCodeAnalysis declaringType, TypeDefinition type);

        TNestedEnum CreateNestedEnum(ITypeWithCodeAnalysis declaringType, TypeDefinition type);

        TNestedInterface CreateNestedInterface(ITypeWithCodeAnalysis declaringType, TypeDefinition type);

        TNestedStruct CreateNestedStruct(ITypeWithCodeAnalysis declaringType, TypeDefinition type);
    }
}

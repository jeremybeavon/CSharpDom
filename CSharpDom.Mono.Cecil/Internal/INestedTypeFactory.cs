using Mono.Cecil;
using System;

namespace CSharpDom.Mono.Cecil.Internal
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
        TNestedAbstractClass CreateNestedAbstractClass(ITypeWithMonoCecil declaringType, TypeDefinition type);

        TNestedClass CreateNestedClass(ITypeWithMonoCecil declaringType, TypeDefinition type);

        TNestedSealedClass CreateNestedSealedClass(ITypeWithMonoCecil declaringType, TypeDefinition type);

        TNestedStaticClass CreateNestedStaticClass(ITypeWithMonoCecil declaringType, TypeDefinition type);

        TNestedDelegate CreateNestedDelegate(ITypeWithMonoCecil declaringType, TypeDefinition type);

        TNestedEnum CreateNestedEnum(ITypeWithMonoCecil declaringType, TypeDefinition type);

        TNestedInterface CreateNestedInterface(ITypeWithMonoCecil declaringType, TypeDefinition type);

        TNestedStruct CreateNestedStruct(ITypeWithMonoCecil declaringType, TypeDefinition type);
    }
}

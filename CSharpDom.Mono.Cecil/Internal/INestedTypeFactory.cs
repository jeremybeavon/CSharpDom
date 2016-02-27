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
        TNestedAbstractClass CreateNestedAbstractClass(ITypeWithMonoCecil declaringType, Type type);

        TNestedClass CreateNestedClass(ITypeWithMonoCecil declaringType, Type type);

        TNestedSealedClass CreateNestedSealedClass(ITypeWithMonoCecil declaringType, Type type);

        TNestedStaticClass CreateNestedStaticClass(ITypeWithMonoCecil declaringType, Type type);

        TNestedDelegate CreateNestedDelegate(ITypeWithMonoCecil declaringType, Type type);

        TNestedEnum CreateNestedEnum(ITypeWithMonoCecil declaringType, Type type);

        TNestedInterface CreateNestedInterface(ITypeWithMonoCecil declaringType, Type type);

        TNestedStruct CreateNestedStruct(ITypeWithMonoCecil declaringType, Type type);
    }
}

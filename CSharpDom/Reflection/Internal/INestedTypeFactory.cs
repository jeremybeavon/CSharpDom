using System;

namespace CSharpDom.Reflection.Internal
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
        TNestedAbstractClass CreateNestedAbstractClass(ITypeWithReflection declaringType, Type type);

        TNestedClass CreateNestedClass(ITypeWithReflection declaringType, Type type);

        TNestedSealedClass CreateNestedSealedClass(ITypeWithReflection declaringType, Type type);

        TNestedStaticClass CreateNestedStaticClass(ITypeWithReflection declaringType, Type type);

        TNestedDelegate CreateNestedDelegate(ITypeWithReflection declaringType, Type type);

        TNestedEnum CreateNestedEnum(ITypeWithReflection declaringType, Type type);

        TNestedInterface CreateNestedInterface(ITypeWithReflection declaringType, Type type);

        TNestedStruct CreateNestedStruct(ITypeWithReflection declaringType, Type type);
    }
}

using System;

namespace CSharpDom.Reflection.Internal
{
    internal interface INestedTypeFactory<
        TNestedClass,
        TNestedDelegate,
        TNestedEnum,
        TNestedInterface,
        TNestedStruct>
    {
        TNestedClass CreateNestedClass(ITypeWithReflection declaringType, Type type);

        TNestedDelegate CreateNestedDelegate(ITypeWithReflection declaringType, Type type);

        TNestedEnum CreateNestedEnum(ITypeWithReflection declaringType, Type type);

        TNestedInterface CreateNestedInterface(ITypeWithReflection declaringType, Type type);

        TNestedStruct CreateNestedStruct(ITypeWithReflection declaringType, Type type);
    }
}

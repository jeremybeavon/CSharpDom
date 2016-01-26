using System;

namespace CSharpDom.Reflection.Internal
{
    internal static class TypeReferenceWithReflectionFactory
    {
        public static ITypeReferenceWithReflection CreateReference(Type type, bool ignoreNestedType = false)
        {
            if (type.IsArray)
            {
                return new ArrayTypeReferenceWithReflection(type);
            }

            if (type.DeclaringType != null && !ignoreNestedType)
            {
                return new NestedTypeReferenceWithReflection(type);
            }

            if (type.IsGenericParameter)
            {
                return new GenericParameterReferenceWithReflection(type);
            }

            switch (type.TypeClassification())
            {
                case TypeClassification.Class:
                    return new ClassReferenceWithReflection(type);
                case TypeClassification.Delegate:
                    return new DelegateReferenceWithReflection(type);
                case TypeClassification.Enum:
                    return new EnumReferenceWithReflection(type);
                case TypeClassification.Interface:
                    return new InterfaceReferenceWithReflection(type);
                case TypeClassification.Struct:
                    return new StructReferenceWithReflection(type);
                default:
                    return new UnspecifiedTypeReferenceWithReflection(type);
            }
        }
    }
}

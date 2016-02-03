using CSharpDom.Reflection.Internal;
using System;

namespace CSharpDom.Reflection
{
    public static class TypeReferenceWithReflectionFactory
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

            if (type == typeof(void))
            {
                return new BuiltInTypeReferenceWithReflection(BuiltInType.Void);
            }

            switch (Type.GetTypeCode(type))
            {
                case TypeCode.Boolean:
                    return new BuiltInTypeReferenceWithReflection(BuiltInType.Bool);
                case TypeCode.Byte:
                    return new BuiltInTypeReferenceWithReflection(BuiltInType.Byte);
                case TypeCode.Char:
                    return new BuiltInTypeReferenceWithReflection(BuiltInType.Char);
                case TypeCode.Decimal:
                    return new BuiltInTypeReferenceWithReflection(BuiltInType.Decimal);
                case TypeCode.Double:
                    return new BuiltInTypeReferenceWithReflection(BuiltInType.Double);
                case TypeCode.Int16:
                    return new BuiltInTypeReferenceWithReflection(BuiltInType.Short);
                case TypeCode.Int32:
                    return new BuiltInTypeReferenceWithReflection(BuiltInType.Int);
                case TypeCode.Int64:
                    return new BuiltInTypeReferenceWithReflection(BuiltInType.Long);
                case TypeCode.SByte:
                    return new BuiltInTypeReferenceWithReflection(BuiltInType.SByte);
                case TypeCode.Single:
                    return new BuiltInTypeReferenceWithReflection(BuiltInType.Float);
                case TypeCode.String:
                    return new BuiltInTypeReferenceWithReflection(BuiltInType.String);
                case TypeCode.UInt16:
                    return new BuiltInTypeReferenceWithReflection(BuiltInType.UShort);
                case TypeCode.UInt32:
                    return new BuiltInTypeReferenceWithReflection(BuiltInType.UInt);
                case TypeCode.UInt64:
                    return new BuiltInTypeReferenceWithReflection(BuiltInType.ULong);
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

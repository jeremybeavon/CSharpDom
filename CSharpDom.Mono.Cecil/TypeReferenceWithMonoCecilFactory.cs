using CSharpDom.Mono.Cecil.Internal;
using System;

namespace CSharpDom.Mono.Cecil
{
    public static class TypeReferenceWithMonoCecilFactory
    {
        public static ITypeReferenceWithMonoCecil CreateReference(Type type, bool ignoreNestedType = false)
        {
            if (type.IsByRef)
            {
                type = type.GetElementType();
            }

            if (type.IsArray)
            {
                return new ArrayTypeReferenceWithMonoCecil(type);
            }

            if (type.DeclaringType != null && !ignoreNestedType)
            {
                return new NestedTypeReferenceWithMonoCecil(type);
            }

            if (type.IsGenericParameter)
            {
                return new GenericParameterReferenceWithMonoCecil(type);
            }

            if (type == typeof(void))
            {
                return new BuiltInTypeReferenceWithMonoCecil(BuiltInType.Void);
            }

            if (type == typeof(object))
            {
                return new BuiltInTypeReferenceWithMonoCecil(BuiltInType.Object);
            }

            switch (Type.GetTypeCode(type))
            {
                case TypeCode.Boolean:
                    return new BuiltInTypeReferenceWithMonoCecil(BuiltInType.Bool);
                case TypeCode.Byte:
                    return new BuiltInTypeReferenceWithMonoCecil(BuiltInType.Byte);
                case TypeCode.Char:
                    return new BuiltInTypeReferenceWithMonoCecil(BuiltInType.Char);
                case TypeCode.Decimal:
                    return new BuiltInTypeReferenceWithMonoCecil(BuiltInType.Decimal);
                case TypeCode.Double:
                    return new BuiltInTypeReferenceWithMonoCecil(BuiltInType.Double);
                case TypeCode.Int16:
                    return new BuiltInTypeReferenceWithMonoCecil(BuiltInType.Short);
                case TypeCode.Int32:
                    return new BuiltInTypeReferenceWithMonoCecil(BuiltInType.Int);
                case TypeCode.Int64:
                    return new BuiltInTypeReferenceWithMonoCecil(BuiltInType.Long);
                case TypeCode.SByte:
                    return new BuiltInTypeReferenceWithMonoCecil(BuiltInType.SByte);
                case TypeCode.Single:
                    return new BuiltInTypeReferenceWithMonoCecil(BuiltInType.Float);
                case TypeCode.String:
                    return new BuiltInTypeReferenceWithMonoCecil(BuiltInType.String);
                case TypeCode.UInt16:
                    return new BuiltInTypeReferenceWithMonoCecil(BuiltInType.UShort);
                case TypeCode.UInt32:
                    return new BuiltInTypeReferenceWithMonoCecil(BuiltInType.UInt);
                case TypeCode.UInt64:
                    return new BuiltInTypeReferenceWithMonoCecil(BuiltInType.ULong);
            }

            switch (type.TypeClassification())
            {
                case TypeClassification.AbstractClass:
                case TypeClassification.Class:
                case TypeClassification.SealedClass:
                case TypeClassification.StaticClass:
                    return new ClassReferenceWithMonoCecil(type);
                case TypeClassification.Delegate:
                    return new DelegateReferenceWithMonoCecil(type);
                case TypeClassification.Enum:
                    return new EnumReferenceWithMonoCecil(type);
                case TypeClassification.Interface:
                    return new InterfaceReferenceWithMonoCecil(type);
                case TypeClassification.Struct:
                    return new StructReferenceWithMonoCecil(type);
                default:
                    return new UnspecifiedTypeReferenceWithMonoCecil(type);
            }
        }
    }
}

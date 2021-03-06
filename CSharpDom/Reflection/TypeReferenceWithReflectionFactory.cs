﻿using CSharpDom.Reflection.Internal;
using System;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public static class TypeReferenceWithReflectionFactory
    {
        public static ITypeReferenceWithReflection CreateReference(Type type, MemberInfo member = null, bool ignoreNestedType = false)
        {
            if (type.IsByRef)
            {
                type = type.GetElementType();
            }

            if (type.IsArray)
            {
                return new ArrayTypeReferenceWithReflection(type, member);
            }

            if (type.IsGenericParameter)
            {
                return new GenericParameterReferenceWithReflection(type);
            }

            if (type.DeclaringType != null && !ignoreNestedType && (member == null || !IsParentType(type, member.DeclaringType)))
            {
                return new NestedTypeReferenceWithReflection(type);
            }

            if (type == typeof(void))
            {
                return new BuiltInTypeReferenceWithReflection(BuiltInType.Void);
            }

            if (type == typeof(object))
            {
                return new BuiltInTypeReferenceWithReflection(BuiltInType.Object);
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
                case TypeClassification.AbstractClass:
                case TypeClassification.Class:
                case TypeClassification.SealedClass:
                case TypeClassification.StaticClass:
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

        private static bool IsParentType (Type type, Type parentType)
        {
            return parentType != null && (type == parentType || IsParentType(type, parentType.DeclaringType));
        }
    }
}

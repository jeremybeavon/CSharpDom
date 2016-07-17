using Mono.Cecil;
using System;
using TypeClassificationEnum = CSharpDom.Mono.Cecil.Internal.TypeClassification;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal static class TypeReferenceExtensions
    {
        public static bool IsClass(this TypeDefinition type)
        {
            return type.IsClass && !type.IsDelegate();
        }

        public static bool IsDelegate(this TypeDefinition type)
        {
            if (!type.IsClass)
            {
                return false;
            }

            for (TypeReference baseType = type.BaseType; baseType != null; baseType = baseType.Resolve().BaseType)
            {
                if (baseType.FullName == "System.Delegate")
                {
                    return true;
                }
            }
            return false;
        }

        public static TypeClassificationEnum TypeClassification(this TypeDefinition type)
        {
            if (type.IsClass())
            {
                if (type.IsAbstract && type.IsSealed)
                {
                    return TypeClassificationEnum.StaticClass;
                }

                if (type.IsAbstract)
                {
                    return TypeClassificationEnum.AbstractClass;
                }

                if (type.IsSealed)

                {
                    return TypeClassificationEnum.SealedClass;
                }
                
                return TypeClassificationEnum.Class;
            }

            if (type.IsDelegate())
            {
                return TypeClassificationEnum.Delegate;
            }

            if (type.IsEnum)
            {
                return TypeClassificationEnum.Enum;
            }

            if (type.IsInterface)
            {
                return TypeClassificationEnum.Interface;
            }

            if (type.IsValueType)
            {
                return TypeClassificationEnum.Struct;
            }

            return TypeClassificationEnum.Unknown;
        }
        
        public static ClassMemberVisibilityModifier ClassMemberVisibility(this TypeDefinition type)
        {
            if (type.IsNestedPublic)
            {
                return ClassMemberVisibilityModifier.Public;
            }

            if (type.IsNestedAssembly)
            {
                return ClassMemberVisibilityModifier.Internal;
            }

            if (type.IsNestedFamilyOrAssembly)
            {
                return ClassMemberVisibilityModifier.ProtectedInternal;
            }

            if (type.IsNestedFamily)
            {
                return ClassMemberVisibilityModifier.Protected;
            }

            if (type.IsNestedPrivate)
            {
                return ClassMemberVisibilityModifier.Private;
            }

            return ClassMemberVisibilityModifier.None;
        }

        public static StaticClassMemberVisibilityModifier StaticClassMemberVisibility(this TypeDefinition type)
        {
            if (type.IsNestedPublic)
            {
                return StaticClassMemberVisibilityModifier.Public;
            }

            if (type.IsNestedAssembly)
            {
                return StaticClassMemberVisibilityModifier.Internal;
            }
            
            if (type.IsNestedPrivate)
            {
                return StaticClassMemberVisibilityModifier.Private;
            }

            return StaticClassMemberVisibilityModifier.None;
        }
        
        public static StructMemberVisibilityModifier StructMemberVisibility(this TypeDefinition type)
        {
            if (type.IsNestedPublic)
            {
                return StructMemberVisibilityModifier.Public;
            }

            if (type.IsNestedAssembly)
            {
                return StructMemberVisibilityModifier.Internal;
            }

            if (type.IsNestedPrivate)
            {
                return StructMemberVisibilityModifier.Private;
            }

            return StructMemberVisibilityModifier.None;
        }

        public static TypeVisibilityModifier Visibility(this TypeDefinition type)
        {
            if (type.IsPublic)
            {
                return TypeVisibilityModifier.Public;
            }

            return TypeVisibilityModifier.Internal;
        }
    }
}

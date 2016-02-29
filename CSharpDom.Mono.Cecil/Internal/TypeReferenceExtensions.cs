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
            throw new NotImplementedException();
            //return type.IsClass && type.IsSubclassOf(typeof(Delegate));
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
            if (type.IsPublic)
            {
                return ClassMemberVisibilityModifier.Public;
            }

            return ClassMemberVisibilityModifier.None;
        }

        public static StaticClassMemberVisibilityModifier StaticClassMemberVisibility(this TypeDefinition type)
        {
            if (type.IsPublic)
            {
                return StaticClassMemberVisibilityModifier.Public;
            }

            return StaticClassMemberVisibilityModifier.None;
        }
        
        public static StructMemberVisibilityModifier StructMemberVisibility(this TypeDefinition type)
        {
            if (type.IsPublic)
            {
                return StructMemberVisibilityModifier.Public;
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

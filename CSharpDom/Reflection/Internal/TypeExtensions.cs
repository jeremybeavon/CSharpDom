using System;
using System.Reflection;
using TypeClassificationEnum = CSharpDom.Reflection.Internal.TypeClassification;

namespace CSharpDom.Reflection.Internal
{
    internal static class TypeExtensions
    {
        private const BindingFlags allMemberFlags =
            BindingFlags.Public |
            BindingFlags.NonPublic |
            BindingFlags.Instance |
            BindingFlags.Static |
            BindingFlags.DeclaredOnly;

        public static bool IsClass(this Type type)
        {
            return type.IsClass && !type.IsDelegate();
        }

        public static bool IsDelegate(this Type type)
        {
            return type.IsClass && type.IsSubclassOf(typeof(Delegate));
        }

        public static TypeClassificationEnum TypeClassification(this Type type)
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

        public static ConstructorInfo[] GetAllConstructors(this Type type)
        {
            return type.GetConstructors(allMemberFlags);
        }
         
        public static EventInfo[] GetAllEvents(this Type type)
        {
            return type.GetEvents(allMemberFlags);
        }

        public static FieldInfo[] GetAllFields(this Type type)
        {
            return type.GetFields(allMemberFlags);
        }

        public static PropertyInfo[] GetAllProperties(this Type type)
        {
            return type.GetProperties(allMemberFlags);
        }

        public static MethodInfo[] GetAllMethods(this Type type)
        {
            return type.GetMethods(allMemberFlags);
        }

        public static ClassMemberVisibilityModifier ClassMemberVisibility(this Type type)
        {
            if (type.IsPublic)
            {
                return ClassMemberVisibilityModifier.Public;
            }

            return ClassMemberVisibilityModifier.None;
        }

        public static StaticClassMemberVisibilityModifier StaticClassMemberVisibility(this Type type)
        {
            if (type.IsPublic)
            {
                return StaticClassMemberVisibilityModifier.Public;
            }

            return StaticClassMemberVisibilityModifier.None;
        }
        
        public static StructMemberVisibilityModifier StructMemberVisibility(this Type type)
        {
            if (type.IsPublic)
            {
                return StructMemberVisibilityModifier.Public;
            }

            return StructMemberVisibilityModifier.None;
        }

        public static TypeVisibilityModifier Visibility(this Type type)
        {
            if (type.IsPublic)
            {
                return TypeVisibilityModifier.Public;
            }

            return TypeVisibilityModifier.Internal;
        }
    }
}

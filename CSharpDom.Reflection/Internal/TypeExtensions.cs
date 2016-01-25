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
                return TypeClassificationEnum.Class;
            }
            else if (type.IsDelegate())
            {
                return TypeClassificationEnum.Delegate;
            }
            else if (type.IsEnum)
            {
                return TypeClassificationEnum.Enum;
            }
            else if (type.IsInterface)
            {
                return TypeClassificationEnum.Interface;
            }
            else if (type.IsValueType)
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

        public static PropertyInfo[] GetAllProperties(this Type type)
        {
            return type.GetProperties(allMemberFlags);
        }

        public static MethodInfo[] GetAllMethods(this Type type)
        {
            return type.GetMethods(allMemberFlags);
        }
    }
}

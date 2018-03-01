using System.Reflection;

namespace CSharpDom.Reflection.Internal
{
    public static class MethodBaseExtensions
    {
        public static ClassMemberVisibilityModifier ClassVisibility(this MethodBase method)
        {
            if (method.IsPublic)
            {
                return ClassMemberVisibilityModifier.Public;
            }

            if (method.IsAssembly)
            {
                return ClassMemberVisibilityModifier.Internal;
            }

            if (method.IsFamilyOrAssembly)
            {
                return ClassMemberVisibilityModifier.ProtectedInternal;
            }

            if (method.IsFamily)
            {
                return ClassMemberVisibilityModifier.Protected;
            }

            if (method.IsPrivate)
            {
                return ClassMemberVisibilityModifier.Private;
            }

            return ClassMemberVisibilityModifier.None;
        }

        public static AbstractMemberVisibilityModifier AbstractClassVisibility(this MethodBase method)
        {
            if (method.IsPublic)
            {
                return AbstractMemberVisibilityModifier.Public;
            }

            if (method.IsAssembly)
            {
                return AbstractMemberVisibilityModifier.Internal;
            }

            if (method.IsFamilyOrAssembly)
            {
                return AbstractMemberVisibilityModifier.ProtectedInternal;
            }

            if (method.IsFamily)
            {
                return AbstractMemberVisibilityModifier.Protected;
            }

            return AbstractMemberVisibilityModifier.None;
        }

        public static StructMemberVisibilityModifier StructVisibility(this MethodBase method)
        {
            if (method.IsPublic)
            {
                return StructMemberVisibilityModifier.Public;
            }

            if (method.IsAssembly)
            {
                return StructMemberVisibilityModifier.Internal;
            }
            
            if (method.IsPrivate)
            {
                return StructMemberVisibilityModifier.Private;
            }

            return StructMemberVisibilityModifier.None;
        }

        public static StaticClassMemberVisibilityModifier StaticClassVisibility(this MethodBase method)
        {
            if (method.IsPublic)
            {
                return StaticClassMemberVisibilityModifier.Public;
            }

            if (method.IsAssembly)
            {
                return StaticClassMemberVisibilityModifier.Internal;
            }

            if (method.IsPrivate)
            {
                return StaticClassMemberVisibilityModifier.Private;
            }

            return StaticClassMemberVisibilityModifier.None;
        }
    }
}

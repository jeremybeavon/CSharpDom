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
    }
}

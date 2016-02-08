using System.Reflection;

namespace CSharpDom.Reflection.Internal
{
    internal static class FieldInfoExtensions
    {
        public static ClassMemberVisibilityModifier ClassVisibility(this FieldInfo fieldInfo)
        {
            if (fieldInfo.IsPublic)
            {
                return ClassMemberVisibilityModifier.Public;
            }

            if (fieldInfo.IsAssembly)
            {
                return ClassMemberVisibilityModifier.Internal;
            }

            if (fieldInfo.IsFamilyOrAssembly)
            {
                return ClassMemberVisibilityModifier.ProtectedInternal;
            }

            if (fieldInfo.IsFamily)
            {
                return ClassMemberVisibilityModifier.Protected;
            }

            if (fieldInfo.IsPrivate)
            {
                return ClassMemberVisibilityModifier.Private;
            }

            return ClassMemberVisibilityModifier.None;
        }
    }
}

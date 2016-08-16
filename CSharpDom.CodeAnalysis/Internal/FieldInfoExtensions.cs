using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal static class FieldDefinitionExtensions
    {
        public static ClassMemberVisibilityModifier ClassVisibility(this FieldDefinition fieldInfo)
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

using System.Reflection;

namespace CSharpDom.Reflection.Internal
{
    public static class MethodBaseExtensions
    {
        public static MemberVisibilityModifier Visibility(this MethodBase method)
        {
            if (method.IsPublic)
            {
                return MemberVisibilityModifier.Public;
            }

            if (method.IsAssembly)
            {
                return MemberVisibilityModifier.Internal;
            }

            if (method.IsFamilyOrAssembly)
            {
                return MemberVisibilityModifier.ProtectedInternal;
            }

            if (method.IsFamily)
            {
                return MemberVisibilityModifier.Protected;
            }

            if (method.IsPrivate)
            {
                return MemberVisibilityModifier.Private;
            }

            return MemberVisibilityModifier.None;
        }
    }
}

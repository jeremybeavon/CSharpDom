using System.Reflection;

namespace CSharpDom.Reflection.Internal
{
    internal static class MethodInfoExtensions
    {
        public static MemberInheritanceModifier InheritanceModifier(this MethodInfo method)
        {
            if (method.IsFinal && method.IsOverride())
            {
                return MemberInheritanceModifier.SealedOverride;
            }

            if (method.IsOverride())
            {
                return MemberInheritanceModifier.Override;
            }

            if (method.IsHideBySig && method.IsStatic)
            {
                return MemberInheritanceModifier.NewStatic;
            }

            if (method.IsHideBySig && method.IsVirtual)
            {
                return MemberInheritanceModifier.NewVirtual;
            }

            if (method.IsHideBySig)
            {
                return MemberInheritanceModifier.New;
            }

            if (method.IsStatic)
            {
                return MemberInheritanceModifier.Static;
            }

            if (method.IsAbstract)
            {
                return MemberInheritanceModifier.Abstract;
            }

            if (method.IsVirtual)
            {
                return MemberInheritanceModifier.Virtual;
            }

            return MemberInheritanceModifier.None;
        }
    }
}

using System.Reflection;

namespace CSharpDom.Reflection.Internal
{
    internal static class MethodInfoExtensions
    {
        public static ClassMemberInheritanceModifier InheritanceModifier(this MethodInfo method)
        {
            if (method.IsFinal && method.IsOverride())
            {
                return ClassMemberInheritanceModifier.SealedOverride;
            }

            if (method.IsOverride())
            {
                return ClassMemberInheritanceModifier.Override;
            }

            if (method.IsHideBySig && method.IsStatic)
            {
                return ClassMemberInheritanceModifier.NewStatic;
            }

            if (method.IsHideBySig && method.IsVirtual)
            {
                return ClassMemberInheritanceModifier.NewVirtual;
            }

            if (method.IsHideBySig)
            {
                return ClassMemberInheritanceModifier.New;
            }

            if (method.IsStatic)
            {
                return ClassMemberInheritanceModifier.Static;
            }

            if (method.IsAbstract)
            {
                return ClassMemberInheritanceModifier.Abstract;
            }

            if (method.IsVirtual)
            {
                return ClassMemberInheritanceModifier.Virtual;
            }

            return ClassMemberInheritanceModifier.None;
        }
    }
}

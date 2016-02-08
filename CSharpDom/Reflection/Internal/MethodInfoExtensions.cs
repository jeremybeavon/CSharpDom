using System;
using System.Reflection;

namespace CSharpDom.Reflection.Internal
{
    internal static class MethodInfoExtensions
    {
        public static ClassMemberInheritanceModifier InheritanceModifier(this MethodInfo method, IInternalTypeWithReflection type)
        {
            return method.InheritanceModifier(() => type.HiddenMembersAnalyzer.IsMethodHidden(method));
        }

        public static ClassMemberInheritanceModifier InheritanceModifier(this MethodInfo method, Func<bool> isHidden)
        {
            if (method.IsFinal && method.IsOverride())
            {
                return ClassMemberInheritanceModifier.SealedOverride;
            }

            if (method.IsOverride())
            {
                return ClassMemberInheritanceModifier.Override;
            }

            if (isHidden())
            {
                if (method.IsStatic)
                {
                    return ClassMemberInheritanceModifier.NewStatic;
                }

                if (method.IsVirtual)
                {
                    return ClassMemberInheritanceModifier.NewVirtual;
                }

                return ClassMemberInheritanceModifier.New;
            }

            if (method.IsStatic)
            {
                return ClassMemberInheritanceModifier.Static;
            }
            
            if (method.IsVirtual)
            {
                return ClassMemberInheritanceModifier.Virtual;
            }

            return ClassMemberInheritanceModifier.None;
        }
    }
}

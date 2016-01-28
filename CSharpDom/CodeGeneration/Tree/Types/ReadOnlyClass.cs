using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyClass
    {
        public static MemberInheritanceModifier InheritanceModifier(ClassMemberInheritanceModifier inheritanceModifier)
        {
            switch (inheritanceModifier)
            {
                case ClassMemberInheritanceModifier.None:
                    return MemberInheritanceModifier.None;
                case ClassMemberInheritanceModifier.Abstract:
                    return MemberInheritanceModifier.Abstract;
                case ClassMemberInheritanceModifier.New:
                    return MemberInheritanceModifier.New;
                case ClassMemberInheritanceModifier.NewStatic:
                    return MemberInheritanceModifier.NewStatic;
                case ClassMemberInheritanceModifier.NewVirtual:
                    return MemberInheritanceModifier.NewVirtual;
                case ClassMemberInheritanceModifier.Override:
                    return MemberInheritanceModifier.Override;
                case ClassMemberInheritanceModifier.SealedOverride:
                    return MemberInheritanceModifier.SealedOverride;
                case ClassMemberInheritanceModifier.Static:
                    return MemberInheritanceModifier.Static;
                case ClassMemberInheritanceModifier.Virtual:
                    return MemberInheritanceModifier.Virtual;
                default:
                    throw new NotSupportedException();
            }
        }

        public static MemberVisibilityModifier Visibility(ClassMemberVisibilityModifier visibility)
        {
            switch (visibility)
            {
                case ClassMemberVisibilityModifier.None:
                    return MemberVisibilityModifier.None;
                case ClassMemberVisibilityModifier.Public:
                    return MemberVisibilityModifier.Public;
                case ClassMemberVisibilityModifier.Internal:
                    return MemberVisibilityModifier.Internal;
                case ClassMemberVisibilityModifier.ProtectedInternal:
                    return MemberVisibilityModifier.ProtectedInternal;
                case ClassMemberVisibilityModifier.Protected:
                    return MemberVisibilityModifier.Protected;
                case ClassMemberVisibilityModifier.Private:
                    return MemberVisibilityModifier.Private;
                default:
                    throw new NotSupportedException();
            }
        }
    }
}

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal static class SyntaxTokenListExtensions
    {
        private static readonly ISet<SyntaxKind> visibilityModifierTokens = new HashSet<SyntaxKind>(new[]
        {
            SyntaxKind.PublicKeyword,
            SyntaxKind.InternalKeyword,
            SyntaxKind.ProtectedKeyword,
            SyntaxKind.PublicKeyword
        });
        private static readonly ISet<SyntaxKind> inheritanceModifierTokens = new HashSet<SyntaxKind>(new[]
        {
            SyntaxKind.NewKeyword,
            SyntaxKind.OverrideKeyword,
            SyntaxKind.SealedKeyword,
            SyntaxKind.StaticKeyword,
            SyntaxKind.VirtualKeyword
        });

        public static SyntaxTokenList Add(this SyntaxTokenList tokens, SyntaxKind kind)
        {
            return tokens.Add(SyntaxFactory.Token(kind));
        }

        public static SyntaxTokenList Remove(this SyntaxTokenList tokens, ISet<SyntaxKind> kind)
        {
            foreach (SyntaxToken token in tokens.Where(token => kind.Contains(token.Kind())))
            {
                tokens = tokens.Remove(token);
            }

            return tokens;
        }

        public static ClassMemberVisibilityModifier ToClassMemberVisibilityModifier(this SyntaxTokenList modifiers)
        {
            if (modifiers.Any(SyntaxKind.PublicKeyword))
            {
                return ClassMemberVisibilityModifier.Public;
            }

            if (modifiers.Any(SyntaxKind.InternalKeyword))
            {
                return modifiers.Any(SyntaxKind.ProtectedKeyword) ?
                    ClassMemberVisibilityModifier.ProtectedInternal :
                    ClassMemberVisibilityModifier.Internal;
            }

            if (modifiers.Any(SyntaxKind.ProtectedKeyword))
            {
                return ClassMemberVisibilityModifier.Protected;
            }

            if (modifiers.Any(SyntaxKind.PrivateKeyword))
            {
                return ClassMemberVisibilityModifier.Private;
            }

            return ClassMemberVisibilityModifier.None;
        }

        public static SyntaxTokenList WithClassMemberVisibilityModifier(
            this SyntaxTokenList tokens,
            ClassMemberVisibilityModifier modifier)
        {
            tokens = tokens.Remove(visibilityModifierTokens);
            switch (modifier)
            {
                case ClassMemberVisibilityModifier.Public:
                    return tokens.Add(SyntaxKind.PublicKeyword);
                case ClassMemberVisibilityModifier.Internal:
                    return tokens.Add(SyntaxKind.InternalKeyword);
                case ClassMemberVisibilityModifier.ProtectedInternal:
                    return tokens.Add(SyntaxKind.ProtectedKeyword).Add(SyntaxKind.InternalKeyword);
                case ClassMemberVisibilityModifier.Protected:
                    return tokens.Add(SyntaxKind.ProtectedKeyword);
                case ClassMemberVisibilityModifier.Private:
                    return tokens.Add(SyntaxKind.PrivateKeyword);
            }

            return tokens;
        }

        public static ClassMemberInheritanceModifier ToClassMemberInheritanceModifier(this SyntaxTokenList modifiers)
        {
            if (modifiers.Any(SyntaxKind.SealedKeyword))
            {
                return ClassMemberInheritanceModifier.SealedOverride;
            }

            if (modifiers.Any(SyntaxKind.OverrideKeyword))
            {
                return ClassMemberInheritanceModifier.Override;
            }

            bool isNew = modifiers.Any(SyntaxKind.NewKeyword);
            if (modifiers.Any(SyntaxKind.StaticKeyword))
            {
                return isNew ? ClassMemberInheritanceModifier.NewStatic : ClassMemberInheritanceModifier.Static;
            }
            else if (modifiers.Any(SyntaxKind.VirtualKeyword))
            {
                return isNew ? ClassMemberInheritanceModifier.NewVirtual : ClassMemberInheritanceModifier.Virtual;
            }
            else if (isNew)
            {
                return ClassMemberInheritanceModifier.New;
            }

            return ClassMemberInheritanceModifier.None;
        }

        public static SyntaxTokenList WithClassMemberInheritanceModifier(
            this SyntaxTokenList tokens,
            ClassMemberInheritanceModifier modifier)
        {
            tokens = tokens.Remove(inheritanceModifierTokens);
            switch (modifier)
            {
                case ClassMemberInheritanceModifier.New:
                    return tokens.Add(SyntaxKind.NewKeyword);
                case ClassMemberInheritanceModifier.NewStatic:
                    return tokens.Add(SyntaxKind.NewKeyword).Add(SyntaxKind.StaticKeyword);
                case ClassMemberInheritanceModifier.NewVirtual:
                    return tokens.Add(SyntaxKind.NewKeyword).Add(SyntaxKind.VirtualKeyword);
                case ClassMemberInheritanceModifier.Override:
                    return tokens.Add(SyntaxKind.OverrideKeyword);
                case ClassMemberInheritanceModifier.SealedOverride:
                    return tokens.Add(SyntaxKind.SealedKeyword).Add(SyntaxKind.OverrideKeyword);
                case ClassMemberInheritanceModifier.Static:
                    return tokens.Add(SyntaxKind.StaticKeyword);
                case ClassMemberInheritanceModifier.Virtual:
                    return tokens.Add(SyntaxKind.VirtualKeyword);
            }

            return tokens;
        }
    }
}

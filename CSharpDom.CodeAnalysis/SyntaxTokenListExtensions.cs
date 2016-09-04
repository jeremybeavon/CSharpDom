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
        private static readonly ISet<SyntaxKind> classFieldModifierTokens = new HashSet<SyntaxKind>(new[]
        {
            SyntaxKind.NewKeyword,
            SyntaxKind.ReadOnlyKeyword,
            SyntaxKind.StaticKeyword,
            SyntaxKind.VolatileKeyword
        });
        private static readonly ISet<SyntaxKind> parameterModifierTokens = new HashSet<SyntaxKind>(new[]
        {
            SyntaxKind.OutKeyword,
            SyntaxKind.ParamsKeyword,
            SyntaxKind.RefKeyword
        });
        private static readonly IDictionary<ClassMemberInheritanceModifier, IndexerInheritanceModifier> indexerModifierMap =
            new Dictionary<ClassMemberInheritanceModifier, IndexerInheritanceModifier>()
            {
                { ClassMemberInheritanceModifier.New, IndexerInheritanceModifier.New },
                { ClassMemberInheritanceModifier.NewVirtual, IndexerInheritanceModifier.NewVirtual },
                { ClassMemberInheritanceModifier.None, IndexerInheritanceModifier.None },
                { ClassMemberInheritanceModifier.Override, IndexerInheritanceModifier.Override },
                { ClassMemberInheritanceModifier.SealedOverride, IndexerInheritanceModifier.SealedOverride },
                { ClassMemberInheritanceModifier.Virtual, IndexerInheritanceModifier.Virtual }
            };
        private static readonly IDictionary<ClassMemberInheritanceModifier, SealedClassMemberInheritanceModifier> sealedClassModifierMap =
            new Dictionary<ClassMemberInheritanceModifier, SealedClassMemberInheritanceModifier>()
            {
                { ClassMemberInheritanceModifier.New, SealedClassMemberInheritanceModifier.New },
                { ClassMemberInheritanceModifier.NewStatic, SealedClassMemberInheritanceModifier.NewStatic },
                { ClassMemberInheritanceModifier.None, SealedClassMemberInheritanceModifier.None },
                { ClassMemberInheritanceModifier.Override, SealedClassMemberInheritanceModifier.Override },
                { ClassMemberInheritanceModifier.SealedOverride, SealedClassMemberInheritanceModifier.SealedOverride },
                { ClassMemberInheritanceModifier.Static, SealedClassMemberInheritanceModifier.Static }
            };
        private static readonly IDictionary<ClassMemberInheritanceModifier, SealedClassIndexerInheritanceModifier> sealedClassIndexerModifierMap =
            new Dictionary<ClassMemberInheritanceModifier, SealedClassIndexerInheritanceModifier>()
            {
                { ClassMemberInheritanceModifier.New, SealedClassIndexerInheritanceModifier.New },
                { ClassMemberInheritanceModifier.None, SealedClassIndexerInheritanceModifier.None },
                { ClassMemberInheritanceModifier.Override, SealedClassIndexerInheritanceModifier.Override },
                { ClassMemberInheritanceModifier.SealedOverride, SealedClassIndexerInheritanceModifier.SealedOverride }
            };
        private static readonly IDictionary<ClassMemberVisibilityModifier, StaticClassMemberVisibilityModifier> staticClassVisibilityModifierMap =
            new Dictionary<ClassMemberVisibilityModifier, StaticClassMemberVisibilityModifier>()
            {
                { ClassMemberVisibilityModifier.Internal, StaticClassMemberVisibilityModifier.Internal },
                { ClassMemberVisibilityModifier.None, StaticClassMemberVisibilityModifier.None },
                { ClassMemberVisibilityModifier.Private, StaticClassMemberVisibilityModifier.Private },
                { ClassMemberVisibilityModifier.Public, StaticClassMemberVisibilityModifier.Public }
            };

        public static SyntaxTokenList Add(this SyntaxTokenList tokens, SyntaxKind kind)
        {
            return tokens.Add(SyntaxFactory.Token(kind));
        }

        public static SyntaxTokenList AddRange(this SyntaxTokenList tokens, IEnumerable<SyntaxKind> kinds)
        {
            return tokens.AddRange(kinds.Select(SyntaxFactory.Token));
        }

        public static SyntaxTokenList AddRange(this SyntaxTokenList tokens, params SyntaxKind[] kinds)
        {
            return tokens.AddRange((IEnumerable<SyntaxKind>)kinds);
        }

        public static SyntaxTokenList Insert(this SyntaxTokenList tokens, int index, SyntaxKind kind)
        {
            return tokens.Insert(index, SyntaxFactory.Token(kind));
        }

        public static SyntaxTokenList InsertRange(this SyntaxTokenList tokens, int index, IEnumerable<SyntaxKind> kinds)
        {
            return tokens.InsertRange(index, kinds.Select(SyntaxFactory.Token));
        }

        public static SyntaxTokenList InsertRange(this SyntaxTokenList tokens, int index, params SyntaxKind[] kinds)
        {
            return tokens.InsertRange(index, (IEnumerable<SyntaxKind>)kinds);
        }

        public static SyntaxTokenList Remove(this SyntaxTokenList tokens, SyntaxKind kind)
        {
            foreach (SyntaxToken token in tokens.Where(token => kind == token.Kind()))
            {
                tokens = tokens.Remove(token);
            }

            return tokens;
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
                    return tokens.Insert(0, SyntaxKind.PublicKeyword);
                case ClassMemberVisibilityModifier.Internal:
                    return tokens.Insert(0, SyntaxKind.InternalKeyword);
                case ClassMemberVisibilityModifier.ProtectedInternal:
                    return tokens.InsertRange(0, SyntaxKind.ProtectedKeyword, SyntaxKind.InternalKeyword);
                case ClassMemberVisibilityModifier.Protected:
                    return tokens.Insert(0, SyntaxKind.ProtectedKeyword);
                case ClassMemberVisibilityModifier.Private:
                    return tokens.Insert(0, SyntaxKind.PrivateKeyword);
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
            ClassMemberInheritanceModifier modifier,
            bool isAsync = false)
        {
            tokens = tokens.Remove(inheritanceModifierTokens);
            IList<SyntaxKind> kinds = new List<SyntaxKind>();
            switch (modifier)
            {
                case ClassMemberInheritanceModifier.New:
                    kinds.Add(SyntaxKind.NewKeyword);
                    break;
                case ClassMemberInheritanceModifier.NewStatic:
                    kinds.Add(SyntaxKind.NewKeyword);
                    kinds.Add(SyntaxKind.StaticKeyword);
                    break;
                case ClassMemberInheritanceModifier.NewVirtual:
                    kinds.Add(SyntaxKind.NewKeyword);
                    kinds.Add(SyntaxKind.VirtualKeyword);
                    break;
                case ClassMemberInheritanceModifier.Override:
                    kinds.Add(SyntaxKind.OverrideKeyword);
                    break;
                case ClassMemberInheritanceModifier.SealedOverride:
                    kinds.Add(SyntaxKind.SealedKeyword);
                    kinds.Add(SyntaxKind.OverrideKeyword);
                    break;
                case ClassMemberInheritanceModifier.Static:
                    kinds.Add(SyntaxKind.StaticKeyword);
                    break;
                case ClassMemberInheritanceModifier.Virtual:
                    kinds.Add(SyntaxKind.VirtualKeyword);
                    break;
            }

            if (kinds.Count != 0)
            {
                tokens = isAsync ? tokens.InsertRange(tokens.Count - 1, kinds) : tokens.AddRange(kinds);
            }
            
            return tokens;
        }

        public static IndexerInheritanceModifier ToIndexerInheritanceModifier(this SyntaxTokenList modifiers)
        {
            return indexerModifierMap[modifiers.ToClassMemberInheritanceModifier()];
        }

        public static SyntaxTokenList WithIndexerInheritanceModifier(
            this SyntaxTokenList tokens,
            IndexerInheritanceModifier modifier)
        {
            return tokens.WithClassMemberInheritanceModifier(indexerModifierMap.First(entry => entry.Value == modifier).Key);
        }

        public static SealedClassMemberInheritanceModifier ToSealedClassMemberInheritanceModifier(this SyntaxTokenList modifiers)
        {
            return sealedClassModifierMap[modifiers.ToClassMemberInheritanceModifier()];
        }

        public static SyntaxTokenList WithSealedClassMemberInheritanceModifier(
            this SyntaxTokenList tokens,
            SealedClassMemberInheritanceModifier modifier)
        {
            return tokens.WithClassMemberInheritanceModifier(sealedClassModifierMap.First(entry => entry.Value == modifier).Key);
        }

        public static SealedClassIndexerInheritanceModifier ToSealedClassIndexerInheritanceModifier(this SyntaxTokenList modifiers)
        {
            return sealedClassIndexerModifierMap[modifiers.ToClassMemberInheritanceModifier()];
        }

        public static SyntaxTokenList WithSealedClassIndexerInheritanceModifier(
            this SyntaxTokenList tokens,
            SealedClassIndexerInheritanceModifier modifier)
        {
            return tokens.WithClassMemberInheritanceModifier(sealedClassIndexerModifierMap.First(entry => entry.Value == modifier).Key);
        }

        public static StaticClassMemberVisibilityModifier ToStaticClassMemberVisibilityModifier(this SyntaxTokenList modifiers)
        {
            return staticClassVisibilityModifierMap[modifiers.ToClassMemberVisibilityModifier()];
        }

        public static SyntaxTokenList WithStaticClassMemberVisibilityModifier(
            this SyntaxTokenList tokens,
            StaticClassMemberVisibilityModifier modifier)
        {
            return tokens.WithClassMemberVisibilityModifier(
                staticClassVisibilityModifierMap.First(entry => entry.Value == modifier).Key);
        }

        public static InterfaceMemberInheritanceModifier ToInterfaceMemberInheritanceModifier(this SyntaxTokenList modifiers)
        {
            return modifiers.Any(SyntaxKind.NewKeyword) ?
                    InterfaceMemberInheritanceModifier.New :
                    InterfaceMemberInheritanceModifier.None;
        }

        public static ClassFieldModifier ToClassFieldModifier(this SyntaxTokenList modifiers)
        {
            bool isNew = modifiers.Any(SyntaxKind.NewKeyword);
            bool isStatic = modifiers.Any(SyntaxKind.StaticKeyword);
            if (modifiers.Any(SyntaxKind.ReadOnlyKeyword))
            {
                if (isNew)
                {
                    return isStatic ? ClassFieldModifier.NewStaticReadOnly : ClassFieldModifier.NewReadOnly;
                }

                return isStatic ? ClassFieldModifier.StaticReadOnly : ClassFieldModifier.ReadOnly;
            }

            if (modifiers.Any(SyntaxKind.VolatileKeyword))
            {
                if (isNew)
                {
                    return isStatic ? ClassFieldModifier.NewStaticVolatile : ClassFieldModifier.NewVolatile;
                }

                return isStatic ? ClassFieldModifier.StaticVolatile : ClassFieldModifier.Volatile;
            }

            if (isStatic)
            {
                return isNew ? ClassFieldModifier.NewStatic : ClassFieldModifier.Static;
            }

            if (isNew)
            {
                return ClassFieldModifier.New;
            }

            return ClassFieldModifier.None;
        }

        public static SyntaxTokenList WithClassFieldModifier(this SyntaxTokenList tokens, ClassFieldModifier modifier)
        {
            tokens = tokens.Remove(classFieldModifierTokens);
            switch (modifier)
            {
                case ClassFieldModifier.New:
                    return tokens.Add(SyntaxKind.NewKeyword);
                case ClassFieldModifier.NewReadOnly:
                    return tokens.AddRange(SyntaxKind.NewKeyword, SyntaxKind.ReadOnlyKeyword);
                case ClassFieldModifier.NewStatic:
                    return tokens.AddRange(SyntaxKind.NewKeyword, SyntaxKind.StaticKeyword);
                case ClassFieldModifier.NewStaticReadOnly:
                    return tokens.AddRange(SyntaxKind.NewKeyword, SyntaxKind.StaticKeyword, SyntaxKind.ReadOnlyKeyword);
                case ClassFieldModifier.NewStaticVolatile:
                    return tokens.AddRange(SyntaxKind.NewKeyword, SyntaxKind.StaticKeyword, SyntaxKind.VolatileKeyword);
                case ClassFieldModifier.NewVolatile:
                    return tokens.AddRange(SyntaxKind.NewKeyword, SyntaxKind.VolatileKeyword);
                case ClassFieldModifier.ReadOnly:
                    return tokens.Add(SyntaxKind.ReadOnlyKeyword);
                case ClassFieldModifier.Static:
                    return tokens.Add(SyntaxKind.StaticKeyword);
                case ClassFieldModifier.StaticReadOnly:
                    return tokens.AddRange(SyntaxKind.StaticKeyword, SyntaxKind.ReadOnlyKeyword);
                case ClassFieldModifier.StaticVolatile:
                    return tokens.AddRange(SyntaxKind.StaticKeyword, SyntaxKind.VolatileKeyword);
                case ClassFieldModifier.Volatile:
                    return tokens.Add(SyntaxKind.VolatileKeyword);
            }

            return tokens;
        }

        public static ParameterModifier ToParameterModifier(this SyntaxTokenList modifiers)
        {
            if (modifiers.Any(SyntaxKind.OutKeyword))
            {
                return ParameterModifier.Out;
            }

            if (modifiers.Any(SyntaxKind.ParamsKeyword))
            {
                return ParameterModifier.Params;
            }

            if (modifiers.Any(SyntaxKind.RefKeyword))
            {
                return ParameterModifier.Ref;
            }

            return ParameterModifier.None;
        }

        public static SyntaxTokenList WithParameterModifier(this SyntaxTokenList tokens, ParameterModifier modifier)
        {
            tokens = tokens.Remove(parameterModifierTokens);
            switch (modifier)
            {
                case ParameterModifier.Out:
                    return tokens.Add(SyntaxKind.OutKeyword);
                case ParameterModifier.Params:
                    return tokens.Add(SyntaxKind.ParamsKeyword);
                case ParameterModifier.Ref:
                    return tokens.Add(SyntaxKind.RefKeyword);
            }

            return tokens;
        }
    }
}

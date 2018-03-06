using System;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using CSharpDom.BaseClasses.Editable;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    public sealed class BuiltInTypeReferenceWithCodeAnalysis :
        EditableBuiltInTypeReference,
        ITypeReferenceWithCodeAnalysis,
        IHasSyntax<PredefinedTypeSyntax>,
        IInternalTypeReferenceWithCodeAnalysis
    {
        private static readonly IDictionary<SyntaxKind, BuiltInType> map = new Dictionary<SyntaxKind, BuiltInType>()
        {
            { SyntaxKind.BoolKeyword, BuiltInType.Bool },
            { SyntaxKind.ByteKeyword, BuiltInType.Byte },
            { SyntaxKind.CharKeyword, BuiltInType.Char },
            { SyntaxKind.DecimalKeyword, BuiltInType.Decimal },
            { SyntaxKind.DoubleKeyword, BuiltInType.Double },
            { SyntaxKind.FloatKeyword, BuiltInType.Float },
            { SyntaxKind.IntKeyword, BuiltInType.Int },
            { SyntaxKind.LongKeyword, BuiltInType.Long },
            { SyntaxKind.ObjectKeyword, BuiltInType.Object },
            { SyntaxKind.SByteKeyword, BuiltInType.SByte },
            { SyntaxKind.ShortKeyword, BuiltInType.Short },
            { SyntaxKind.StringKeyword, BuiltInType.String },
            { SyntaxKind.UIntKeyword, BuiltInType.UInt },
            { SyntaxKind.ULongKeyword, BuiltInType.ULong },
            { SyntaxKind.UShortKeyword, BuiltInType.UShort },
            { SyntaxKind.VoidKeyword, BuiltInType.Void }
        };

        private readonly TypeReferenceNode<BuiltInTypeReferenceWithCodeAnalysis, PredefinedTypeSyntax> node;

        public BuiltInTypeReferenceWithCodeAnalysis()
        {
            node = new TypeReferenceNode<BuiltInTypeReferenceWithCodeAnalysis, PredefinedTypeSyntax>(this);
        }
        
        public PredefinedTypeSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        public override BuiltInType Type
        {
            get { return map[node.Syntax.Keyword.Kind()]; }
            set { node.Syntax = node.Syntax.WithKeyword(SyntaxFactory.Token(map.First(entry => entry.Value == value).Key)); }
        }

        public string Name
        {
            get => node.Syntax.ToString();
            set => throw new NotImplementedException();
        }

        TypeSyntax IHasSyntax<TypeSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (PredefinedTypeSyntax)value; }
        }

        INode<TypeSyntax> IHasNode<TypeSyntax>.Node => node;
    }
}

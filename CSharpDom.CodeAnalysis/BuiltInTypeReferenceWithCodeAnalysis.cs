using System;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using CSharpDom.Editable;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    public sealed class BuiltInTypeReferenceWithCodeAnalysis :
        EditableBuiltInTypeReference,
        ITypeReferenceWithCodeAnalysis,
        IHasSyntax<PredefinedTypeSyntax>
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

        private readonly Node<PredefinedTypeSyntax> node;
        private readonly ValueNode<PredefinedTypeSyntax, BuiltInType> type;

        public BuiltInTypeReferenceWithCodeAnalysis()
        {
            node = new Node<PredefinedTypeSyntax>();
            type = new ValueNode<PredefinedTypeSyntax, BuiltInType>(
                node,
                syntax => map[syntax.Keyword.Kind()],
                (syntax, value) => syntax.WithKeyword(SyntaxFactory.Token(map.First(entry => entry.Value == value).Key)));
        }
        
        public PredefinedTypeSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        public override BuiltInType Type
        {
            get { return type.Value; }
            set { type.Value = value; }
        }
    }
}

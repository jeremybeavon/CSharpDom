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

        private readonly Func<PredefinedTypeSyntax> getType;
        private readonly Action<PredefinedTypeSyntax> setType;
        
        public PredefinedTypeSyntax Syntax
        {
            get { return getType(); }
        }

        public override BuiltInType Type
        {
            get { return map[getType().Keyword.Kind()]; }
            set { setType(getType().WithKeyword(SyntaxFactory.Token(map.First(entry => entry.Value == value).Key))); }
        }
    }
}

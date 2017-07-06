using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal static class EnumDeclarationSyntaxExtensions
    {
        private static readonly Map<SyntaxKind, EnumBaseType> enumBaseTypeMap =
            new Map<SyntaxKind, EnumBaseType>()
            {
                { SyntaxKind.ByteKeyword, EnumBaseType.Byte },
                { SyntaxKind.SByteKeyword, EnumBaseType.SByte },
                { SyntaxKind.ShortKeyword, EnumBaseType.Short },
                { SyntaxKind.UShortKeyword, EnumBaseType.UShort },
                { SyntaxKind.IntKeyword, EnumBaseType.Int },
                { SyntaxKind.UIntKeyword, EnumBaseType.UInt },
                { SyntaxKind.LongKeyword, EnumBaseType.Long },
                { SyntaxKind.ULongKeyword, EnumBaseType.ULong }
            };

        public static EnumBaseType ToBaseType(this EnumDeclarationSyntax syntax)
        {
            if (syntax.BaseList == null)
            {
                return EnumBaseType.None;
            }

            if (syntax.BaseList.Types.Count == 0)
            {
                throw new NotSupportedException();
            }

            PredefinedTypeSyntax typeSyntax = syntax.BaseList.Types[0].Type as PredefinedTypeSyntax;
            if (typeSyntax == null)
            {
                throw new NotSupportedException();
            }

            return enumBaseTypeMap[typeSyntax.Keyword.Kind()];
        }

        public static EnumDeclarationSyntax ToBaseType(this EnumDeclarationSyntax syntax, EnumBaseType baseType)
        {
            if (baseType == EnumBaseType.None)
            {
                return syntax.WithBaseList(null);
            }

            SyntaxKind keyword = enumBaseTypeMap[baseType];
            PredefinedTypeSyntax typeSyntax = SyntaxFactory.PredefinedType(SyntaxFactory.Token(keyword));
            SeparatedSyntaxList<BaseTypeSyntax> baseTypes =
                SyntaxFactory.SingletonSeparatedList<BaseTypeSyntax>(SyntaxFactory.SimpleBaseType(typeSyntax));
            return syntax.WithBaseList(SyntaxFactory.BaseList(baseTypes));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.Common;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithSymbols
{
    public interface INestedEnumWithSymbols : IEnum, IHasDeclaringType<ITypeWithSymbols>,
        IHasEnumMembers<INestedEnumMemberWithSymbols>,
        IHasSymbol<INamedTypeSymbol>,
        IHasSyntax<INestedEnumSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}

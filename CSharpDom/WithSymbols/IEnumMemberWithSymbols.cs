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
    public interface IEnumMemberWithSymbols : IEnumMember,
        IHasDeclaringType<IEnumWithSymbols>,
        IHasSymbol<IFieldSymbol>,
        IHasSyntax<IEnumMemberSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}

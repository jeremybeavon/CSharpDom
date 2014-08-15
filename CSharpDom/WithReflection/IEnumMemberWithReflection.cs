using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithReflection
{
    public interface IEnumMemberWithReflection : IEnumMember,
        IHasDeclaringType<IEnumWithReflection>,
        IHasSymbol<IFieldSymbol>,
        IHasSyntax<IEnumMemberSyntax>,
        IHasSymbols<IEnumMemberWithSymbols>
    {
        void Accept(IReflectionVisitor visitor);
    }
}

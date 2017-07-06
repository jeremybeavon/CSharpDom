using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.Statements
{
    internal interface IInternalForStatementInitializer : IForInitializerStatementWithCodeAnalysis, IHasNode<VariableDeclarationSyntax>
    {
    }
}

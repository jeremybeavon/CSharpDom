using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Expressions
{
    internal interface IInternalArgument : IArgumentWithCodeAnalysis, IHasNode<ArgumentSyntax>
    {
    }
}

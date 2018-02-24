using CSharpDom.Common.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public interface IArgumentWithCodeAnalysis :
        IEditableArgument<IExpressionWithCodeAnalysis>,
        IHasSyntax<ArgumentSyntax>
    {
    }
}

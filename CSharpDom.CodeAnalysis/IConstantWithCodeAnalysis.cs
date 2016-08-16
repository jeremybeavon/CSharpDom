using CSharpDom.Common;
using CSharpDom.Mono.Cecil.ConstantExpressions;

namespace CSharpDom.CodeAnalysis
{
    public interface IConstantWithCodeAnalysis : IConstant<IConstantExpressionWithCodeAnalysis>
    {
    }
}

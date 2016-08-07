using CSharpDom.Common;
using CSharpDom.Mono.Cecil.ConstantExpressions;

namespace CSharpDom.Mono.Cecil
{
    public interface IConstantWithMonoCecil : IConstant<IConstantExpressionWithMonoCecil>
    {
    }
}

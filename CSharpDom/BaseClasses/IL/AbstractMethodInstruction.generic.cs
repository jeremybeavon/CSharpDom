using CSharpDom.Common.IL;

namespace CSharpDom.BaseClasses.IL
{
    public abstract class AbstractMethodInstruction<TMethodReference> :
        AbstractMethodInstruction,
        IMethodInstruction<TMethodReference>
    {
        public abstract TMethodReference Method { get; }
    }
}

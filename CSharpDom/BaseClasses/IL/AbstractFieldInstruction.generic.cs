using CSharpDom.Common.IL;

namespace CSharpDom.BaseClasses.IL
{
    public abstract class AbstractFieldInstruction<TFieldReference> :
        AbstractFieldInstruction,
        IFieldInstruction<TFieldReference>
    {
        public abstract TFieldReference Field { get; }
    }
}

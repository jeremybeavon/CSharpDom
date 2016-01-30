using CSharpDom.Common.IL;

namespace CSharpDom.BaseClasses.IL
{
    public abstract class AbstractSignatureInstruction : ISignatureInstruction
    {
        public abstract byte[] Signature { get; }

        public abstract int Token { get; }

        public void Accept(IILInstructionVisitor visitor)
        {
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
        }
    }
}

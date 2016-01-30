namespace CSharpDom.Common.IL
{
    public interface ISignatureInstruction : IILInstruction, IHasToken
    {
        byte[] Signature { get; }
    }
}

using Mono.Cecil.Cil;

namespace CSharpDom.Mono.Cecil.Cil
{
    public interface IHasOpCode
    {
        OpCode OpCode { get; }
    }
}

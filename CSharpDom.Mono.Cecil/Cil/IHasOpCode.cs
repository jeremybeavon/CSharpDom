using System.Reflection.Emit;

namespace CSharpDom.Mono.Cecil.Cil
{
    public interface IHasOpCode
    {
        OpCode OpCode { get; }
    }
}

using System.Reflection.Emit;

namespace CSharpDom.Reflection.Emit
{
    public interface IHasOpCode
    {
        OpCode OpCode { get; }
    }
}

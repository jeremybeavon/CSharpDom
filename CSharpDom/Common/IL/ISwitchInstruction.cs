using System.Collections.Generic;

namespace CSharpDom.Common.IL
{
    public interface ISwitchInstruction : IILInstruction
    {
        IReadOnlyList<int> Deltas { get; }
    }
}

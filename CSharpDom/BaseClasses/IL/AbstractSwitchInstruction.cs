using CSharpDom.Common.IL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.BaseClasses.IL
{
    public abstract class AbstractSwitchInstruction : ISwitchInstruction
    {
        public abstract IReadOnlyList<int> Deltas { get; }

        public void Accept(IILInstructionVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}

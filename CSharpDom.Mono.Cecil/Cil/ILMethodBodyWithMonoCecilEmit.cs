using CSharpDom.Common;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Mono.Cecil.Cil
{
    public sealed class ILMethodBodyWithMonoCecilEmit : IMethodBody<IILInstructionWithMonoCecilEmit>
    {
        public ILMethodBodyWithMonoCecilEmit(MethodBase method)
        {
            Instructions = ILInstructionBuilder.GetInstructions(method);
        }

        public IReadOnlyList<IILInstructionWithMonoCecilEmit> Instructions { get; private set; }

        IReadOnlyList<IILInstructionWithMonoCecilEmit> IMethodBody<IILInstructionWithMonoCecilEmit>.Statements
        {
            get { return Instructions; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitMethodBody(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}

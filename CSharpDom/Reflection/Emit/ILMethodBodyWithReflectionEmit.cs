using CSharpDom.Common;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Reflection.Emit
{
    public sealed class ILMethodBodyWithReflectionEmit : IMethodBody<IILInstructionWithReflectionEmit>
    {
        public ILMethodBodyWithReflectionEmit(MethodBase method)
        {
            Instructions = ILInstructionBuilder.GetInstructions(method);
        }

        public IReadOnlyList<IILInstructionWithReflectionEmit> Instructions { get; private set; }

        IReadOnlyList<IILInstructionWithReflectionEmit> IMethodBody<IILInstructionWithReflectionEmit>.Statements
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

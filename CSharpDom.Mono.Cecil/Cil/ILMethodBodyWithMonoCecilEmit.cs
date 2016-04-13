using CSharpDom.Common;
using Mono.Cecil;
using System.Collections.Generic;

namespace CSharpDom.Mono.Cecil.Cil
{
    public sealed class ILMethodBodyWithMonoCecilCil : IMethodBody<IILInstructionWithMonoCecilCil>
    {
        public ILMethodBodyWithMonoCecilCil(MethodDefinition method)
        {
            Instructions = new IILInstructionWithMonoCecilCil[0];
        }

        public IReadOnlyList<IILInstructionWithMonoCecilCil> Instructions { get; private set; }

        IReadOnlyList<IILInstructionWithMonoCecilCil> IMethodBody<IILInstructionWithMonoCecilCil>.Statements
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

using CSharpDom.Common;
using CSharpDom.Common.IL;
using CSharpDom.Common.Statements;
using CSharpDom.Wrappers.Internal.Statements;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class MethodBodyWrapper : AbstractWrapper<IMethodBody>
    {
        public MethodBodyWrapper(IMethodBody methodBody)
            : base(methodBody)
        {
        }

        public override void VisitMethodBody<TStatement>(IMethodBody<TStatement> methodBody)
        {
            Value = new MethodBody();
            IReadOnlyList<TStatement> statements = methodBody.Statements;
            if (statements.Count == 0)
            {
                return;
            }

            if (statements[0] is IStatement)
            {
                Value.Statements = statements.Cast<IStatement>().ToStatementListUsingWrapper();
            }
            else if (statements[0] is IILInstruction)
            {
                Value.Instructions = ILInstructionWrapper.GetInstructions(statements.Cast<IILInstruction>());
            }
        }
    }
}

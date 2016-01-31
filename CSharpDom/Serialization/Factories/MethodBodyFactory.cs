using CSharpDom.Common;
using CSharpDom.Common.IL;
using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Factories.Statements;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.Serialization.Factories
{
    public sealed class MethodBodyFactory : AbstractFactory<IMethodBody, MethodBody>
    {
        public MethodBodyFactory(IMethodBody methodBody)
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
                Value.Statements = statements.Cast<IStatement>().ToStatementListUsingFactory();
            }
            else if (statements[0] is IILInstruction)
            {
                Value.Instructions = ILInstructionFactory.GetInstructions(statements.Cast<IILInstruction>());
            }
        }
    }
}

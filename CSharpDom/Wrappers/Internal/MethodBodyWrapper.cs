using CSharpDom.Common;
using CSharpDom.Common.IL;
using CSharpDom.Common.Statements;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class MethodBodyWrapper : AbstractWrapper<IMethodBody>, IMethodBodyWrapper
    {
        public MethodBodyWrapper(IMethodBody methodBody)
            : base(methodBody)
        {
        }

        public IReadOnlyList<IStatement> Statements
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Accept(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public override void VisitMethodBody<TStatement>(IMethodBody<TStatement> methodBody)
        {
        }
    }
}

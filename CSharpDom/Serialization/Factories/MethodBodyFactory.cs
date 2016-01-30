using CSharpDom.Common;
using System;

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
            throw new NotImplementedException();
        }
    }
}

using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class AnonymousMethodParameterFactory :
        AbstractExpressionFactory<IAnonymousMethodParameter, AnonymousMethodParameter>
    {
        public AnonymousMethodParameterFactory(IAnonymousMethodParameter parameter)
            : base(parameter)
        {
        }

        public override void VisitAnonymousMethodParameter<TTypeReference>(
            IAnonymousMethodParameter<TTypeReference> anonymousMethodParameter)
        {
            Value = new AnonymousMethodParameter()
            {
                Modifier = anonymousMethodParameter.Modifier,
                Name = anonymousMethodParameter.Name,
                ParameterType = new TypeReferenceFactory(anonymousMethodParameter.ParameterType).Value
            };
        }
    }
}

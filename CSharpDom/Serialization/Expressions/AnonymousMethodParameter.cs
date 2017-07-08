using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class AnonymousMethodParameter : IAnonymousMethodParameter<TypeReference>
    {
        public string Name { get; set; }

        public AnonymousMethodParameterModifier Modifier { get; set; }

        public TypeReference ParameterType { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitAnonymousMethodParameter(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}

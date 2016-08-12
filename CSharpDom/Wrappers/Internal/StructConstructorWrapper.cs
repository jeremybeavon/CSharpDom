using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructConstructorWrapper : AbstractWrapper<IStructConstructor>
    {
        public StructConstructorWrapper(IStructConstructor constructor)
            : base(constructor)
        {
        }

        public override void VisitStructConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(
            IStructConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor)
        {
            Value = new StructConstructor()
            {
                Attributes = constructor.Attributes.ToAttributeListUsingWrapper(),
                Body = new MethodBodyWrapper(constructor.Body).Value,
                Parameters = constructor.Parameters.ToList(parameter => new ConstructorParameterWrapper(parameter).Value),
                Visibility = constructor.Visibility
            };
        }
    }
}

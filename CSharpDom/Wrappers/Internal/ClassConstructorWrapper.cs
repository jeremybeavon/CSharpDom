using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ClassConstructorWrapper : AbstractWrapper<IClassConstructor>
    {
        public ClassConstructorWrapper(IClassConstructor constructor)
            : base(constructor)
        {
        }

        public override void VisitClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(
            IClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor)
        {
            Value = new ClassConstructor()
            {
                Attributes = constructor.Attributes.ToAttributeListUsingWrapper(),
                Body = new MethodBodyWrapper(constructor.Body).Value,
                Parameters = constructor.Parameters.ToList(parameter => new ConstructorParameterWrapper(parameter).Value),
                Visibility = constructor.Visibility
            };
        }
    }
}

namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithNestedAbstractPartialClassWithGenericParameterInterfaceConstraint
    {
        public abstract partial class Class
        {
            public abstract class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}

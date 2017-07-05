namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedAbstractPartialClassWithGenericParameterInterfaceConstraint
    {
        public partial class Class
        {
            public abstract class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}

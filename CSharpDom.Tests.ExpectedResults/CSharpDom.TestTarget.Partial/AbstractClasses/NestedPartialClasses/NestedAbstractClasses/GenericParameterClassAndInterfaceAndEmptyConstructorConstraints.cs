namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedAbstractPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public abstract class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}

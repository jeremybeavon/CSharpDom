namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedStaticPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public static class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}

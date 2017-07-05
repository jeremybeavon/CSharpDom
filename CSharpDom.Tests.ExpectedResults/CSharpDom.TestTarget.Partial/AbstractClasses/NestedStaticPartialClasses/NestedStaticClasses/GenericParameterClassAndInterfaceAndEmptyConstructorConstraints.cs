namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithNestedStaticPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static partial class Class
        {
            public static class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}

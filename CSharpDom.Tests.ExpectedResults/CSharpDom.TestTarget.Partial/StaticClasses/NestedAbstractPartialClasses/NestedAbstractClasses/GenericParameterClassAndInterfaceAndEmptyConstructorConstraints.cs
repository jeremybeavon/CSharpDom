namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedAbstractPartialClassWithNestedAbstractPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract partial class Class
        {
            public abstract class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}

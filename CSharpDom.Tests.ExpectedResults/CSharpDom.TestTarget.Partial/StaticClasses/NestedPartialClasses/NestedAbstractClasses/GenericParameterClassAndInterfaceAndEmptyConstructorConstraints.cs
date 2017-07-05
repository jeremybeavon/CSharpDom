namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedPartialClassWithNestedAbstractPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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

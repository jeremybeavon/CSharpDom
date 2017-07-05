namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedStaticClasses
{
    public partial class PartialClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public static class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}

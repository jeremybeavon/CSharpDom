namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedClasses
{
    public static class StaticClassWithNestedPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}

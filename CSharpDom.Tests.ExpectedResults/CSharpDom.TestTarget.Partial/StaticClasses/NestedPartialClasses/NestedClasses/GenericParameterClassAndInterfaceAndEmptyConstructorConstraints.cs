namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedClasses
{
    public static class StaticClassWithNestedPartialClassWithNestedPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}

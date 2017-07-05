namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedStaticClasses
{
    public class ClassWithNestedPartialClassWithNestedStaticPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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

namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedClasses
{
    public class ClassWithNestedStaticPartialClassWithNestedPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static partial class Class
        {
            public class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}

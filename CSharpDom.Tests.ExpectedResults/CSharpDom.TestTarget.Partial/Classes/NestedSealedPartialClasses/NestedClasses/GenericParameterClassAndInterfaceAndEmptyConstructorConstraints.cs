namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedClasses
{
    public class ClassWithNestedSealedPartialClassWithNestedPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed partial class Class
        {
            public class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}

namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedSealedClasses
{
    public class ClassWithNestedSealedPartialClassWithNestedSealedPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed partial class Class
        {
            public sealed class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}

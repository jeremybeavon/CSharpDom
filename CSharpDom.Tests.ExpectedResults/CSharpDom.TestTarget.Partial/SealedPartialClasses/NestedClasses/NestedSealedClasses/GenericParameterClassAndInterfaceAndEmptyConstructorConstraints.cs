namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedSealedClasses
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public class Class
        {
            public sealed class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}

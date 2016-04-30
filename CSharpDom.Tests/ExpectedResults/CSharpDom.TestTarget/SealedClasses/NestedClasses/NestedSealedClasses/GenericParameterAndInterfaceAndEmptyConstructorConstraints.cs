namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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

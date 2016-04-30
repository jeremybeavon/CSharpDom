namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedClasses
{
    public sealed class SealedClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}

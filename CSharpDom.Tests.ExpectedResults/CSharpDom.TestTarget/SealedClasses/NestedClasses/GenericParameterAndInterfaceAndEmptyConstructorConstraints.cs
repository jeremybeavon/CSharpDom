namespace CSharpDom.TestTarget.SealedClasses.NestedClasses
{
    public sealed class SealedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}

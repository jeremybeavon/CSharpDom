namespace CSharpDom.TestTarget.Classes.NestedSealedClasses
{
    public class ClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}

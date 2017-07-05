namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedClasses
{
    public class ClassWithNestedSealedPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}

namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses
{
    public static partial class StaticPartialClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}

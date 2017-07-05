namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedClasses
{
    public sealed class SealedClassWithNestedPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}

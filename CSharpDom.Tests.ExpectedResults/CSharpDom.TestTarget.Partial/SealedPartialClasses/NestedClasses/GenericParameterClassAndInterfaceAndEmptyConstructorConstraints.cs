namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses
{
    public sealed partial class SealedPartialClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}

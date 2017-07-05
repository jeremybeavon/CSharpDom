namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.NestedClasses
{
    public sealed class SealedClassWithNestedSealedPartialClassWithNestedPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed partial class Class
        {
            public class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}

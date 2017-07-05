namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedSealedClasses
{
    public partial class PartialClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public sealed class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}

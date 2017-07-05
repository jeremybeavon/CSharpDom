namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedSealedClasses
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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

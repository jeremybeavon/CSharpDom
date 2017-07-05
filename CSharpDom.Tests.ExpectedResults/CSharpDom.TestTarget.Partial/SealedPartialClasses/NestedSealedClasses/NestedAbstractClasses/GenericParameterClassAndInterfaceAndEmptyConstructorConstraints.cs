namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.NestedAbstractClasses
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public abstract class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}

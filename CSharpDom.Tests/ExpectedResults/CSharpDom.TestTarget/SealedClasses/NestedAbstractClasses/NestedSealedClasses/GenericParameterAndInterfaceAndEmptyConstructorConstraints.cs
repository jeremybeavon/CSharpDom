namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public sealed class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}

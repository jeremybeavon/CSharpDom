namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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

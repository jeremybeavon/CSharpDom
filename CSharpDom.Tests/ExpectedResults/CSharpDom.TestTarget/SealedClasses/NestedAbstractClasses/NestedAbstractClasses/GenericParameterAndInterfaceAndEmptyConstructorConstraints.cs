namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public abstract class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}

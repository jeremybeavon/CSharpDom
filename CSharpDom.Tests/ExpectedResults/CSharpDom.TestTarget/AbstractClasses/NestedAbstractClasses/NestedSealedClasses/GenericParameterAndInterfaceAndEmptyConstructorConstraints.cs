namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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

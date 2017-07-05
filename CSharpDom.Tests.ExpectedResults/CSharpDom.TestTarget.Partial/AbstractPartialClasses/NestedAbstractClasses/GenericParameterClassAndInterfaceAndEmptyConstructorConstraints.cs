namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}

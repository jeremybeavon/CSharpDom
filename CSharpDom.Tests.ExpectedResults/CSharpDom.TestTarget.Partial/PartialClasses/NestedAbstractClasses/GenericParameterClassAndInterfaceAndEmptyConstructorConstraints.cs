namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses
{
    public partial class PartialClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}

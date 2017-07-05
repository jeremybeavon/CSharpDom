namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}

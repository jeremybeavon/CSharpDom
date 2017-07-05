namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses
{
    public abstract partial class AbstractPartialClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}

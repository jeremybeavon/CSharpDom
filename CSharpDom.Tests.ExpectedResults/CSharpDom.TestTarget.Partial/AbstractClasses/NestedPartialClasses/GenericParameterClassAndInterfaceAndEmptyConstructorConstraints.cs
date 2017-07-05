namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}

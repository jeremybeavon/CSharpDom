namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}

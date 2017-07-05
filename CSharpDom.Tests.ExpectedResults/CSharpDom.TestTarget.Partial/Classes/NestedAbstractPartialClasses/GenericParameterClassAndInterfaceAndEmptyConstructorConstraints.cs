namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractClasses
{
    public class ClassWithNestedAbstractPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}

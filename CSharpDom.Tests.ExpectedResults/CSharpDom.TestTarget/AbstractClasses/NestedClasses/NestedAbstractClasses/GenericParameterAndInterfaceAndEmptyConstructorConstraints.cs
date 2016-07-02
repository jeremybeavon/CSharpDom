namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}

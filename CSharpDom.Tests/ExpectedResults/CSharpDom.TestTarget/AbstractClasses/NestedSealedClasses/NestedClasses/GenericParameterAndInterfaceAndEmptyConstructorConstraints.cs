namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}

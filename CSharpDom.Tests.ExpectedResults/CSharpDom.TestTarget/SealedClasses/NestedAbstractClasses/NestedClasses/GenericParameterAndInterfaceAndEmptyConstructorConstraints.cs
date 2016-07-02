namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedClasses
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}

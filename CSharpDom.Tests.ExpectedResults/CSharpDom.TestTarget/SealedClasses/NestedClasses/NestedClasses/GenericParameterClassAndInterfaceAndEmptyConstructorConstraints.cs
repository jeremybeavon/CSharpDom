namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedClasses
{
    public sealed class SealedClassWithNestedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public class Class
        {
            public class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}

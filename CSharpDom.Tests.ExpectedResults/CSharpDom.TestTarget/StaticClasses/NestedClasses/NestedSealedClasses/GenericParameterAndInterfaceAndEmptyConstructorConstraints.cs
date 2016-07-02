namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public class Class
        {
            public sealed class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}

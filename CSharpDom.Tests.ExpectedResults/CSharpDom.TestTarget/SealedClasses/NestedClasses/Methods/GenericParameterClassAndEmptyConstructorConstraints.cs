namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Methods
{
    public sealed class SealedClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public T Method<T>()
                where T : class, new()
            {
                return default(T);
            }
        }
    }
}

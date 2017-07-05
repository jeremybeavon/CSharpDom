namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Methods
{
    public static partial class StaticPartialClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
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

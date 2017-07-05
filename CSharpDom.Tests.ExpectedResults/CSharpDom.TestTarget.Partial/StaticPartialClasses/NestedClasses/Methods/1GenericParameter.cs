namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Methods
{
    public static partial class StaticPartialClassWithNestedClassWithMethodWith1GenericParameter
    {
        public class Class
        {
            public T Method<T>()
            {
                return default(T);
            }
        }
    }
}

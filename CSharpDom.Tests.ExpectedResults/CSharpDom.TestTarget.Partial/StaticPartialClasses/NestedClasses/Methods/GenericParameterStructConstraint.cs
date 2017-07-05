namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Methods
{
    public static partial class StaticPartialClassWithNestedClassWithMethodWithGenericParameterStructConstraint
    {
        public class Class
        {
            public T Method<T>()
                where T : struct
            {
                return default(T);
            }
        }
    }
}

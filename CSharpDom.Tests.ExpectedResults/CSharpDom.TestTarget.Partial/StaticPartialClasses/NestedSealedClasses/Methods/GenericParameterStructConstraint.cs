namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Methods
{
    public static partial class StaticPartialClassWithNestedSealedClassWithMethodWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public T Method<T>()
                where T : struct
            {
                return default(T);
            }
        }
    }
}

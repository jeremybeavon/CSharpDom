namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.Methods
{
    public sealed class SealedClassWithNestedStaticPartialClassWithMethodWithGenericParameterEmptyConstructorConstraint
    {
        public static partial class Class
        {
            public static T Method<T>()
                where T : new()
            {
                return default(T);
            }
        }
    }
}

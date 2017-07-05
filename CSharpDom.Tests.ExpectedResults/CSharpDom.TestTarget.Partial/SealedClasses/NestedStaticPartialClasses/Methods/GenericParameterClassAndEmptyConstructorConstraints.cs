namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.Methods
{
    public sealed class SealedClassWithNestedStaticPartialClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static partial class Class
        {
            public static T Method<T>()
                where T : class, new()
            {
                return default(T);
            }
        }
    }
}

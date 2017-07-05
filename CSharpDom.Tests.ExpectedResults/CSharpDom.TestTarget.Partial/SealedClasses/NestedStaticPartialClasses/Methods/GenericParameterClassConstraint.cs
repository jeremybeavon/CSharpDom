namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.Methods
{
    public sealed class SealedClassWithNestedStaticPartialClassWithMethodWithGenericParameterClassConstraint
    {
        public static partial class Class
        {
            public static T Method<T>()
                where T : class
            {
                return default(T);
            }
        }
    }
}

namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.Methods
{
    public sealed class SealedClassWithNestedStaticPartialClassWithMethodWithGenericParameterStructConstraint
    {
        public static partial class Class
        {
            public static T Method<T>()
                where T : struct
            {
                return default(T);
            }
        }
    }
}

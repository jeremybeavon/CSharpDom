namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.Methods
{
    public sealed class SealedClassWithNestedStaticPartialClassWithMethodWithGenericParameterInterfaceConstraint
    {
        public static partial class Class
        {
            public static T Method<T>()
                where T : IInterface
            {
                return default(T);
            }
        }
    }
}

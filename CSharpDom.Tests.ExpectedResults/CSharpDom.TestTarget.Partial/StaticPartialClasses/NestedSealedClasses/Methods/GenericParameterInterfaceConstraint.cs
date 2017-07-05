namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Methods
{
    public static partial class StaticPartialClassWithNestedSealedClassWithMethodWithGenericParameterInterfaceConstraint
    {
        public sealed class Class
        {
            public T Method<T>()
                where T : IInterface
            {
                return default(T);
            }
        }
    }
}

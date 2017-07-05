namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Methods
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithMethodWithGenericParameterInterfaceConstraint
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

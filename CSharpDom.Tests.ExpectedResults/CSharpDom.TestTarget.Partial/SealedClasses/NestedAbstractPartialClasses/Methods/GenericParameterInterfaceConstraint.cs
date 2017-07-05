namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Methods
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithMethodWithGenericParameterInterfaceConstraint
    {
        public abstract partial class Class
        {
            public T Method<T>()
                where T : IInterface
            {
                return default(T);
            }
        }
    }
}

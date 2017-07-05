namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Methods
{
    public sealed partial class SealedPartialClassWithMethodWithGenericParameterInterfaceConstraint
    {
        public T Method<T>()
            where T : IInterface
        {
            return default(T);
        }
    }
}

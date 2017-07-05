namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Methods
{
    public sealed partial class SealedPartialClassWithMethodWithGenericParameterBaseClassConstraint
    {
        public T Method<T>()
            where T : BaseClass
        {
            return default(T);
        }
    }
}

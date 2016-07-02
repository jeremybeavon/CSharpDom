namespace CSharpDom.TestTarget.SealedClasses.Methods
{
    public sealed class SealedClassWithMethodWithGenericParameterBaseSealedClassConstraint
    {
        public T Method<T>()
            where T : BaseClass
        {
            return default(T);
        }
    }
}

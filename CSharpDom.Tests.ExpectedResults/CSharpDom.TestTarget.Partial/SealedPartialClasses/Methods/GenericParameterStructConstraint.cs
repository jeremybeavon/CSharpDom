namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Methods
{
    public sealed partial class SealedPartialClassWithMethodWithGenericParameterStructConstraint
    {
        public T Method<T>()
            where T : struct
        {
            return default(T);
        }
    }
}

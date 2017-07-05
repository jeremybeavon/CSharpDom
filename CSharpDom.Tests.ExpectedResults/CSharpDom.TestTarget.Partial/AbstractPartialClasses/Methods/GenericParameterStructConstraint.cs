namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Methods
{
    public abstract partial class AbstractPartialClassWithMethodWithGenericParameterStructConstraint
    {
        public T Method<T>()
            where T : struct
        {
            return default(T);
        }
    }
}

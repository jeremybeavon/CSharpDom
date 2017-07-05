namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Methods
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithMethodWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public T Method<T>()
                where T : class
            {
                return default(T);
            }
        }
    }
}

namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Methods
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class
        {
            public T Method<T>()
                where T : new()
            {
                return default(T);
            }
        }
    }
}

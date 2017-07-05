namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Methods
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithMethodWithGenericParameterEmptyConstructorConstraint
    {
        public sealed partial class Class
        {
            public T Method<T>()
                where T : new()
            {
                return default(T);
            }
        }
    }
}

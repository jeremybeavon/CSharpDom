namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Methods
{
    public sealed partial class SealedPartialClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public T Method<T>()
                where T : new()
            {
                return default(T);
            }
        }
    }
}

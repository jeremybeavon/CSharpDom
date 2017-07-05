namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Methods
{
    public partial class PartialClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraint
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

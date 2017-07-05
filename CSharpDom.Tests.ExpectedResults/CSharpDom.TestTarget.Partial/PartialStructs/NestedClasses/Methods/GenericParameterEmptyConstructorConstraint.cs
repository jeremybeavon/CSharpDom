namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Methods
{
    public partial struct PartialStructWithWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraint
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

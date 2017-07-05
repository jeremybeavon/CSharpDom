namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Methods
{
    public partial struct PartialStructWithWithNestedClassWithMethodWithGenericParameterClassConstraint
    {
        public class Class
        {
            public T Method<T>()
                where T : class
            {
                return default(T);
            }
        }
    }
}

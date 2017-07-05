namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Methods
{
    public partial struct PartialStructWithWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public T Method<T>()
                where T : class, new()
            {
                return default(T);
            }
        }
    }
}

namespace CSharpDom.TestTarget.Structs.NestedClasses.Methods
{
    public struct StructWithNestedClassWithMethodWithGenericParameterClassConstraint
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

namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.Methods
{
    public class ClassWithNestedStructWithMethodWithGenericParameterClassConstraint
    {
        public struct Struct
        {
            public T Method<T>()
                where T : class
            {
                return default(T);
            }
        }
    }
}

namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.Methods
{
    public class ClassWithNestedStructWithMethodWithGenericParameterStructConstraint
    {
        public struct Struct
        {
            public T Method<T>()
                where T : struct
            {
                return default(T);
            }
        }
    }
}

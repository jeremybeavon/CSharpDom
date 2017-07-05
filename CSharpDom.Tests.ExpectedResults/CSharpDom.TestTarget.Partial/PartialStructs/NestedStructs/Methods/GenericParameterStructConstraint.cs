namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Methods
{
    public partial struct PartialStructWithWithNestedStructWithMethodWithGenericParameterStructConstraint
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

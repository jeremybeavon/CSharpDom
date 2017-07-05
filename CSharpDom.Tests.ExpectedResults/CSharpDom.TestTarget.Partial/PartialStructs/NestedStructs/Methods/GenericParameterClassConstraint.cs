namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Methods
{
    public partial struct PartialStructWithWithNestedStructWithMethodWithGenericParameterClassConstraint
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

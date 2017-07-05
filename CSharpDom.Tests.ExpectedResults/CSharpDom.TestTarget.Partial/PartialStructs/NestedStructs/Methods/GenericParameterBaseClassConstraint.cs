namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Methods
{
    public partial struct PartialStructWithWithNestedStructWithMethodWithGenericParameterBaseClassConstraint
    {
        public struct Struct
        {
            public T Method<T>()
                where T : BaseClass
            {
                return default(T);
            }
        }
    }
}

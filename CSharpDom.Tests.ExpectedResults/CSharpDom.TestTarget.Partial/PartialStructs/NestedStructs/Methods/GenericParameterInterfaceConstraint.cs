namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Methods
{
    public partial struct PartialStructWithWithNestedStructWithMethodWithGenericParameterInterfaceConstraint
    {
        public struct Struct
        {
            public T Method<T>()
                where T : IInterface
            {
                return default(T);
            }
        }
    }
}

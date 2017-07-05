namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedAbstractClasses
{
    public struct StructWithNestedStructWithNestedAbstractPartialClassWithGenericParameterClassConstraint
    {
        public struct Struct
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}

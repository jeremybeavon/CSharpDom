namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedAbstractClasses
{
    public struct StructWithNestedStructWithNestedAbstractPartialClassWithGenericParameterStructConstraint
    {
        public struct Struct
        {
            public abstract class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}

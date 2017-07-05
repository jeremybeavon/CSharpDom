namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedAbstractClasses
{
    public struct StructWithNestedStructWithNestedAbstractPartialClassWithGenericParameterBaseClassConstraint
    {
        public struct Struct
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}

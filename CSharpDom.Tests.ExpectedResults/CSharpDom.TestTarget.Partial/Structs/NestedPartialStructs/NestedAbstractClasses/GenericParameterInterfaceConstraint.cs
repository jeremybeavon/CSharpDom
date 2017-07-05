namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedAbstractClasses
{
    public struct StructWithNestedStructWithNestedAbstractPartialClassWithGenericParameterInterfaceConstraint
    {
        public struct Struct
        {
            public abstract class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}

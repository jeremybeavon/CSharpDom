namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedStructs
{
    public struct StructWithNestedAbstractPartialClassWithNestedStructWithGenericParameterStructConstraint
    {
        public abstract partial class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}

namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedStructs
{
    public struct StructWithNestedAbstractPartialClassWithNestedStructWithGenericParameterClassConstraint
    {
        public abstract partial class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}

namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedStructs
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}

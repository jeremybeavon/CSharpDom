namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedStructs
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public struct Struct
        {
            public struct NestedStruct<T>
                where T : IInterface
            {
            }
        }
    }
}

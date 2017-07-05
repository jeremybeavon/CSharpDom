namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.NestedStructs
{
    public partial class PartialClassWithNestedStaticClassWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public static class Class
        {
            public struct NestedStruct<T>
                where T : IInterface
            {
            }
        }
    }
}

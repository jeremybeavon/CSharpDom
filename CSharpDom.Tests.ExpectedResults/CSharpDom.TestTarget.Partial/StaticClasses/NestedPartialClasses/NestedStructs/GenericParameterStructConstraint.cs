namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedStructs
{
    public static class StaticClassWithNestedPartialClassWithNestedStructWithGenericParameterStructConstraint
    {
        public partial class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}

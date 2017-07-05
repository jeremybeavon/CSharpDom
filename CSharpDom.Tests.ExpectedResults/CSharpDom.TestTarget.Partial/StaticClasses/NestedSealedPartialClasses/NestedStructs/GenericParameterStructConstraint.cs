namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.NestedStructs
{
    public static class StaticClassWithNestedSealedPartialClassWithNestedStructWithGenericParameterStructConstraint
    {
        public sealed partial class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}

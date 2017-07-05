namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.NestedStructs
{
    public static class StaticClassWithNestedSealedPartialClassWithNestedStructWithGenericParameterClassConstraint
    {
        public sealed partial class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}

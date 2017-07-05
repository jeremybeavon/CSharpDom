namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.NestedStructs
{
    public static class StaticClassWithNestedSealedPartialClassWithNestedStructWithGenericParameterBaseClassConstraint
    {
        public sealed partial class Class
        {
            public struct NestedStruct<T>
                where T : BaseClass
            {
            }
        }
    }
}

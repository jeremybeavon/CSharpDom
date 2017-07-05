namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.NestedStructs
{
    public partial class PartialClassWithNestedStaticClassWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public static class Class
        {
            public struct NestedStruct<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}

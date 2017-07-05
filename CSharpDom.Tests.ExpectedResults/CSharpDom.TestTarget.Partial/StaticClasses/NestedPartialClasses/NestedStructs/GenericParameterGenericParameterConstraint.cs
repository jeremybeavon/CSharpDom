namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedStructs
{
    public static class StaticClassWithNestedPartialClassWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public partial class Class
        {
            public struct NestedStruct<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}

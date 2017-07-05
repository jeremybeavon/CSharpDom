namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedStructs
{
    public sealed class SealedClassWithNestedPartialClassWithNestedStructWithGenericParameterGenericParameterConstraint
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

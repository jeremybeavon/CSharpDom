namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedStructs
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public class Class
        {
            public struct NestedStruct<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}

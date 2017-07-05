namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.NestedClasses
{
    public sealed partial class SealedPartialClassWithNestedStructWithNestedClassWithGenericParameterGenericParameterConstraint
    {
        public struct Struct
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}

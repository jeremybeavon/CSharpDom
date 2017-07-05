namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedClasses
{
    public struct StructWithNestedSealedPartialClassWithNestedPartialClassWithGenericParameterGenericParameterConstraint
    {
        public sealed partial class Class
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}

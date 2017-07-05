namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedAbstractClasses
{
    public struct StructWithNestedSealedPartialClassWithNestedAbstractPartialClassWithGenericParameterGenericParameterConstraint
    {
        public sealed partial class Class
        {
            public abstract class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}

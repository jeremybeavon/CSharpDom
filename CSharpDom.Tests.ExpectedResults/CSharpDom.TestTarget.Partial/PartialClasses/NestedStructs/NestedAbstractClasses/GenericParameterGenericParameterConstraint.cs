namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedAbstractClasses
{
    public partial class PartialClassWithNestedStructWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
    {
        public struct Struct
        {
            public abstract class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}

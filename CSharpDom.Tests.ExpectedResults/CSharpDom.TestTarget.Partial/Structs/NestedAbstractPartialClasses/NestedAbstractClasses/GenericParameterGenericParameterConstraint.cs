namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedAbstractClasses
{
    public struct StructWithNestedAbstractPartialClassWithNestedAbstractPartialClassWithGenericParameterGenericParameterConstraint
    {
        public abstract partial class Class
        {
            public abstract class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}

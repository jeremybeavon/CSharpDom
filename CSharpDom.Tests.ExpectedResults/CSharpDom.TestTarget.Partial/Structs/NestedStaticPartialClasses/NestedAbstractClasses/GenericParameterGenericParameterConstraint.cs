namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedAbstractClasses
{
    public struct StructWithNestedStaticPartialClassWithNestedAbstractPartialClassWithGenericParameterGenericParameterConstraint
    {
        public static partial class Class
        {
            public abstract class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}

namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.NestedStructs
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class
        {
            public struct NestedStruct<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}

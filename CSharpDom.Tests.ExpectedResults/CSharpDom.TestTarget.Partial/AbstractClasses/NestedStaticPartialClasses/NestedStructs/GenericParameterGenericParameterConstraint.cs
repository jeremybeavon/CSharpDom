namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public static partial class Class
        {
            public struct NestedStruct<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}

namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public abstract partial class Class
        {
            public struct NestedStruct<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}

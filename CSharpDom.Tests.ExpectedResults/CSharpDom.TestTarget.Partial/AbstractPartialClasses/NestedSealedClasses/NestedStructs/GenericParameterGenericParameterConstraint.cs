namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedStructs
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class
        {
            public struct NestedStruct<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}

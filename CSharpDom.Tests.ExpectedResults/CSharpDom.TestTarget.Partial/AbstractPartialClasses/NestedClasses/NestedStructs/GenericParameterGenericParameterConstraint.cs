namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.NestedStructs
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public class Class
        {
            public struct NestedStruct<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}

namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedClasses
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedClassWithGenericParameterGenericParameterConstraint
    {
        public struct Struct
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}

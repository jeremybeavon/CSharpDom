namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedClasses
{
    public partial class PartialClassWithNestedStructWithNestedClassWithGenericParameterGenericParameterConstraint
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

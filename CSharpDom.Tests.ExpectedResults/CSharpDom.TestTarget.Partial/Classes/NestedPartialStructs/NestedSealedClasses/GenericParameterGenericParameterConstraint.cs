namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedSealedClasses
{
    public class ClassWithNestedStructWithNestedSealedPartialClassWithGenericParameterGenericParameterConstraint
    {
        public struct Struct
        {
            public sealed class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}

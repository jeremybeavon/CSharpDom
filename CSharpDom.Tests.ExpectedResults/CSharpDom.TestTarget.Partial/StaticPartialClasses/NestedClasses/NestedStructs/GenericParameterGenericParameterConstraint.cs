namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.NestedStructs
{
    public static partial class StaticPartialClassWithNestedClassWithNestedStructWithGenericParameterGenericParameterConstraint
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

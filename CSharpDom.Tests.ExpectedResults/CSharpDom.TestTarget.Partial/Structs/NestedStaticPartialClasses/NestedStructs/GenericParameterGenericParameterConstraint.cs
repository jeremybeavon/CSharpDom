namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedStructs
{
    public struct StructWithNestedStaticPartialClassWithNestedStructWithGenericParameterGenericParameterConstraint
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

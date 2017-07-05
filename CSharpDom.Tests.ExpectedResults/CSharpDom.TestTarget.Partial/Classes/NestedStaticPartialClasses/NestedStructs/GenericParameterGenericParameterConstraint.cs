namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedStructs
{
    public class ClassWithNestedStaticPartialClassWithNestedStructWithGenericParameterGenericParameterConstraint
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

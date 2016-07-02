namespace CSharpDom.TestTarget.Classes.NestedStructs.NestedStaticClasses
{
    public class ClassWithNestedStructWithNestedStaticClassWithGenericParameterGenericParameterConstraint
    {
        public struct Struct
        {
            public static class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}

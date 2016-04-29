namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedStructs
{
    public class ClassWithNestedStaticClassWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public static class Class
        {
            public struct NestedStruct<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}

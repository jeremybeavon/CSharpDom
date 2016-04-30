namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedStructs
{
    public static class StaticClassWithNestedClassWithNestedStructWithGenericParameterGenericParameterConstraint
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

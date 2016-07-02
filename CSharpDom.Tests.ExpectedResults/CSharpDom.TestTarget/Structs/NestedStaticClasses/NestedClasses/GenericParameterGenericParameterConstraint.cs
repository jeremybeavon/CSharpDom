namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedClasses
{
    public struct StructWithNestedStaticClassWithNestedClassWithGenericParameterGenericParameterConstraint
    {
        public static class Class
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}

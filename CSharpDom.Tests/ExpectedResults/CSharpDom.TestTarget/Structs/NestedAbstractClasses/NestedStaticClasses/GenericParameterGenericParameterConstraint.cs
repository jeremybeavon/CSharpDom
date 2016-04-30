namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedStaticClasses
{
    public struct StructWithNestedAbstractClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class
        {
            public static class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}

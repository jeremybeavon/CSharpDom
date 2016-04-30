namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterGenericParameterConstraint
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

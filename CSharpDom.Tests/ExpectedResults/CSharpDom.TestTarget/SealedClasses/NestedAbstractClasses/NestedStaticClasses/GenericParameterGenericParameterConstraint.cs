namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint
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

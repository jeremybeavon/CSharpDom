namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
    {
        public static class Class
        {
            public abstract class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}

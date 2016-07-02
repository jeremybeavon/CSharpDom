namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedClasses
{
    public sealed class SealedClassWithNestedStaticClassWithNestedClassWithGenericParameterGenericParameterConstraint
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

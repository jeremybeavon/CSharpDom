namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint
    {
        public class Class
        {
            public static class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}

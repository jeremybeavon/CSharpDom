namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint
    {
        public class Class
        {
            public sealed class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}

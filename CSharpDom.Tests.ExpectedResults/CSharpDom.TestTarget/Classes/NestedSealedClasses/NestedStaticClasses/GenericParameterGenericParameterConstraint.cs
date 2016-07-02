namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedStaticClasses
{
    public class ClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class
        {
            public static class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}

namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedSealedClasses
{
    public class ClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint
    {
        public static class Class
        {
            public sealed class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}

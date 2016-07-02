namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint
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

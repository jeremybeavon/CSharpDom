namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedClasses
{
    public sealed class SealedClassWithNestedClassWithNestedClassWithGenericParameterGenericParameterConstraint
    {
        public class Class
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}

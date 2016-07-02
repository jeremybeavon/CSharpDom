namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedSealedClasses
{
    public class ClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class
        {
            public sealed class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}

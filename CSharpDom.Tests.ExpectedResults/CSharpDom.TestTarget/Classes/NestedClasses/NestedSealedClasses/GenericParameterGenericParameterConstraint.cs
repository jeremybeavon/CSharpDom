namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedSealedClasses
{
    public class ClassWithNestedClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint
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

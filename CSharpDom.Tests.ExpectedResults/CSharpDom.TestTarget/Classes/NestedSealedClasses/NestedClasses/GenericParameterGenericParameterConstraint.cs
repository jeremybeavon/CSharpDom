namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedClasses
{
    public class ClassWithNestedSealedClassWithNestedClassWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}

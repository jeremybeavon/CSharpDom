namespace CSharpDom.TestTarget.Classes.NestedClasses
{
    public class ClassWithNestedClassWithGenericParameterGenericParameterConstraint
    {
        public class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}

namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedClasses
{
    public class ClassWithNestedClassWithNestedClassWithGenericParameterGenericParameterConstraint
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

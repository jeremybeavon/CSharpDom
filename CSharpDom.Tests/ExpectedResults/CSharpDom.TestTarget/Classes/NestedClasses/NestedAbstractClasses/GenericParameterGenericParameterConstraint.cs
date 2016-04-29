namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedAbstractClasses
{
    public class ClassWithNestedClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
    {
        public class Class
        {
            public abstract class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}

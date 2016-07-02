namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedClasses
{
    public class ClassWithNestedAbstractClassWithNestedClassWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}

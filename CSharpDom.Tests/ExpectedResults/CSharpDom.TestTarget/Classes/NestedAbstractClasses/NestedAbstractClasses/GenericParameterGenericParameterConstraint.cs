namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedAbstractClasses
{
    public class ClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class
        {
            public abstract class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}

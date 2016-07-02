namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}

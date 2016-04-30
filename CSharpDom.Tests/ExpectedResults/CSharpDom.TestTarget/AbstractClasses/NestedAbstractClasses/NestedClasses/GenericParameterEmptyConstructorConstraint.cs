namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}

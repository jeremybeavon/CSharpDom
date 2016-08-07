namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassConstraint
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}

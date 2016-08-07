namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedClassWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}

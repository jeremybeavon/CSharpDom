namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedClassWithNestedClassWithGenericParameterClassConstraint
    {
        public class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}

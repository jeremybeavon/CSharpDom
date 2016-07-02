namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedClassWithNestedClassWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}

namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedClassWithNestedClassWithGenericParameterStructConstraint
    {
        public class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}

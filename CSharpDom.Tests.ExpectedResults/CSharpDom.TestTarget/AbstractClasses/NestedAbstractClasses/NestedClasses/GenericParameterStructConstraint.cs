namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedClassWithGenericParameterStructConstraint
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}

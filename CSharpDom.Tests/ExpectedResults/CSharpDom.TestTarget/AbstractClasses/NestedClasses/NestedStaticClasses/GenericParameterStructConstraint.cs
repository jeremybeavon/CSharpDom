namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedClassWithNestedStaticClassWithGenericParameterStructConstraint
    {
        public class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}

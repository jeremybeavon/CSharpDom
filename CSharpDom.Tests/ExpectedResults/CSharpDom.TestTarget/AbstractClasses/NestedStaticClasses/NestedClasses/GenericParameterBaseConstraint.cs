namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedClassWithGenericParameterBaseClassConstraint
    {
        public static class Class
        {
            public class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}

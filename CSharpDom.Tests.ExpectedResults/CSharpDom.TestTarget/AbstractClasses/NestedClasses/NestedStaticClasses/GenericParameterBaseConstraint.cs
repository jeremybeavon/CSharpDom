namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedClassWithNestedStaticClassWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public static class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}

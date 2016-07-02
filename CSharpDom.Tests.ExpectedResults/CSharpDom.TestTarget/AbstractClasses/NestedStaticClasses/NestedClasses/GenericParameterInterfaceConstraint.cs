namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedClassWithGenericParameterInterfaceConstraint
    {
        public static class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}

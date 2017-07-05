namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.NestedClasses
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithNestedClassWithGenericParameterInterfaceConstraint
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

namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.NestedClasses
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNestedClassWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}

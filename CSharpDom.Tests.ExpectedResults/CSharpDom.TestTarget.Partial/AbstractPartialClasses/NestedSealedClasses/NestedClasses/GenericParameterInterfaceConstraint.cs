namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedClasses
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedClassWithGenericParameterInterfaceConstraint
    {
        public sealed class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}

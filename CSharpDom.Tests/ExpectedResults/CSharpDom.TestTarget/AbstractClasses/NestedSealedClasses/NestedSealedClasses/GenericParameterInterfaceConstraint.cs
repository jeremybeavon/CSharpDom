namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterInterfaceConstraint
    {
        public sealed class Class
        {
            public sealed class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}

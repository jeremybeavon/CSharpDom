namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterInterfaceConstraint
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

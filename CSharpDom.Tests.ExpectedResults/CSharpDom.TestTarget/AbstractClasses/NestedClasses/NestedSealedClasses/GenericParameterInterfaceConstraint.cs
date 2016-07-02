namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedClassWithNestedSealedClassWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public sealed class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}

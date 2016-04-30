namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedClassWithGenericParameterInterfaceConstraint
    {
        public class Class<T>
            where T : IInterface
        {
        }
    }
}

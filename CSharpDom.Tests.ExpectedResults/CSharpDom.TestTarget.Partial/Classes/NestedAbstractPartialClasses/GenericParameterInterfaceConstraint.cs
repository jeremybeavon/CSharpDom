namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractClasses
{
    public class ClassWithNestedAbstractPartialClassWithGenericParameterInterfaceConstraint
    {
        public abstract class Class<T>
            where T : IInterface
        {
        }
    }
}

namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses
{
    public class ClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint
    {
        public abstract class Class<T>
            where T : IInterface
        {
        }
    }
}

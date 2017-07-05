namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedInterfaces
{
    public class ClassWithNestedAbstractPartialClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public abstract partial class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}

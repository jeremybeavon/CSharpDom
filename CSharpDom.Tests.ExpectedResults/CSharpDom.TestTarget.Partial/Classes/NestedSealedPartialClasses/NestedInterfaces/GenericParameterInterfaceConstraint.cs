namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedInterfaces
{
    public class ClassWithNestedSealedPartialClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public sealed partial class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}

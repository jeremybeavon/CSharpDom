namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedInterfaces
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}

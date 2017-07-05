namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedInterfaces
{
    public class ClassWithNestedPartialClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public partial class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}

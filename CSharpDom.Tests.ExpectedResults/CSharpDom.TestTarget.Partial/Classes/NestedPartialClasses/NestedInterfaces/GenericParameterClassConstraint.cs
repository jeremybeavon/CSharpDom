namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedInterfaces
{
    public class ClassWithNestedPartialClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public partial class Class
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}

namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedInterfaces
{
    public partial class PartialClassWithNestedClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public class Class
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}

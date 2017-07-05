namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedInterfaces
{
    public partial class PartialClassWithNestedClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public class Class
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}

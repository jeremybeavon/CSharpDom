namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedInterfaces
{
    public class ClassWithNestedPartialClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public partial class Class
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}

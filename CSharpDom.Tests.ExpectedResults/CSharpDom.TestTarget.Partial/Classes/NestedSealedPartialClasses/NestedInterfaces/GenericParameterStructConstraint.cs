namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedInterfaces
{
    public class ClassWithNestedSealedPartialClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public sealed partial class Class
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}

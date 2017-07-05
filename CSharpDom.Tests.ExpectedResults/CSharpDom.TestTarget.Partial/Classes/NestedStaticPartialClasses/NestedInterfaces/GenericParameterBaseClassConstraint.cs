namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedInterfaces
{
    public class ClassWithNestedStaticPartialClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public static partial class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}

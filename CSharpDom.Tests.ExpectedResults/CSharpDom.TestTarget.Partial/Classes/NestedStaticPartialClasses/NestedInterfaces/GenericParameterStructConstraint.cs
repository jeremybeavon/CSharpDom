namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedInterfaces
{
    public class ClassWithNestedStaticPartialClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public static partial class Class
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}

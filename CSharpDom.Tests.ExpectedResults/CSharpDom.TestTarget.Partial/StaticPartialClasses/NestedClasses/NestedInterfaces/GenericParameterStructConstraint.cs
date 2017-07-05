namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.NestedInterfaces
{
    public static partial class StaticPartialClassWithNestedClassWithNestedInterfaceWithGenericParameterStructConstraint
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

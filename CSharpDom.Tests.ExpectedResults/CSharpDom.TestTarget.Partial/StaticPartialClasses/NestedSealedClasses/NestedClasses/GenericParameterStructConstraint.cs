namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.NestedClasses
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNestedClassWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}

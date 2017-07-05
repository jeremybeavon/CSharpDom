namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedSealedClasses
{
    public class ClassWithNestedStaticPartialClassWithNestedSealedPartialClassWithGenericParameterStructConstraint
    {
        public static partial class Class
        {
            public sealed class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}

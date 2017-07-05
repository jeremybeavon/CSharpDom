namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses
{
    public static partial class StaticPartialClassWithNestedClassWithGenericParameterStructConstraint
    {
        public class Class<T>
            where T : struct
        {
        }
    }
}

namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedStaticClasses
{
    public class ClassWithNestedAbstractPartialClassWithNestedStaticPartialClassWithGenericParameterStructConstraint
    {
        public abstract partial class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}

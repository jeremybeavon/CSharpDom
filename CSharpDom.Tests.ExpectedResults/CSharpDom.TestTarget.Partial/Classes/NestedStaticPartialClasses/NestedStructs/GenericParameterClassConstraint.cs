namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedStructs
{
    public class ClassWithNestedStaticPartialClassWithNestedStructWithGenericParameterClassConstraint
    {
        public static partial class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}

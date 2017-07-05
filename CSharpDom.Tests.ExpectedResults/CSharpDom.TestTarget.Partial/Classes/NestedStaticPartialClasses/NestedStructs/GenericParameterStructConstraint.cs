namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedStructs
{
    public class ClassWithNestedStaticPartialClassWithNestedStructWithGenericParameterStructConstraint
    {
        public static partial class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}

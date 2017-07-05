namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedStructs
{
    public class ClassWithNestedStaticPartialClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static partial class Class
        {
            public struct NestedStruct<T>
                where T : class, new()
            {
            }
        }
    }
}

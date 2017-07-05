namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedStructs
{
    public class ClassWithNestedStaticPartialClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public static partial class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}

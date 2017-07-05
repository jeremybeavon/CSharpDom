namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.NestedStructs
{
    public static partial class StaticPartialClassWithNestedClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}

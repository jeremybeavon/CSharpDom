namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
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

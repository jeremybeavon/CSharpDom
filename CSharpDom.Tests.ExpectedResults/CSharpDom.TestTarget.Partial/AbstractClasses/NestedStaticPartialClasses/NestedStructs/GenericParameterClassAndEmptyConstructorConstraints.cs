namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
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

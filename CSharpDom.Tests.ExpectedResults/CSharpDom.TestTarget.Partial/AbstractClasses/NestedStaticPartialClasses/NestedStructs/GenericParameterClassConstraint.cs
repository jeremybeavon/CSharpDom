namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithNestedStructWithGenericParameterClassConstraint
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

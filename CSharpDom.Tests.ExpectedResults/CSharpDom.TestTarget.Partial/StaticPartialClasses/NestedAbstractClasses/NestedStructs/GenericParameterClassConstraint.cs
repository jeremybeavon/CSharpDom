namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.NestedStructs
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNestedStructWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}

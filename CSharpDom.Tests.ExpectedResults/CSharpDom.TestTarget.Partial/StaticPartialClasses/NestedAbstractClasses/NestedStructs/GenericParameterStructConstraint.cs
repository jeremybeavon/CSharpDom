namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.NestedStructs
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNestedStructWithGenericParameterStructConstraint
    {
        public abstract class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}

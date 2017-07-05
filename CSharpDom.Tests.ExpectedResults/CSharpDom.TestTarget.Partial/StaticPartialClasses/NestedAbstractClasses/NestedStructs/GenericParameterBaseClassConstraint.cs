namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.NestedStructs
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNestedStructWithGenericParameterBaseClassConstraint
    {
        public abstract class Class
        {
            public struct NestedStruct<T>
                where T : BaseClass
            {
            }
        }
    }
}

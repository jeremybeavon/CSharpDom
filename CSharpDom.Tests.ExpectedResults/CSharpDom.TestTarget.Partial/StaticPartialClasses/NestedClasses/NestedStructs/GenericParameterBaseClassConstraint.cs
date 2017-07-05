namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.NestedStructs
{
    public static partial class StaticPartialClassWithNestedClassWithNestedStructWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public struct NestedStruct<T>
                where T : BaseClass
            {
            }
        }
    }
}

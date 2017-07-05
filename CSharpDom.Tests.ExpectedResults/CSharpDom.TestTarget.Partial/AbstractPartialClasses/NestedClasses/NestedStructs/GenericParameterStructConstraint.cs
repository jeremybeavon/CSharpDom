namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.NestedStructs
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNestedStructWithGenericParameterStructConstraint
    {
        public class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}

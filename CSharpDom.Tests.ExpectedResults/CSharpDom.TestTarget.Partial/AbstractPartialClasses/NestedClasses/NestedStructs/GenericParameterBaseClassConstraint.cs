namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.NestedStructs
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNestedStructWithGenericParameterBaseClassConstraint
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

namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedStructs
{
    public class ClassWithNestedAbstractPartialClassWithNestedStructWithGenericParameterBaseClassConstraint
    {
        public abstract partial class Class
        {
            public struct NestedStruct<T>
                where T : BaseClass
            {
            }
        }
    }
}

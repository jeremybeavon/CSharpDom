namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedStructs
{
    public class ClassWithNestedAbstractPartialClassWithNestedStructWithGenericParameterClassConstraint
    {
        public abstract partial class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}

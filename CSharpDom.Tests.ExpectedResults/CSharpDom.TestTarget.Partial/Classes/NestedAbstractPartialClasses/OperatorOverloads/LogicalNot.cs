namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.OperatorOverloads
{
    public class ClassWithNestedAbstractPartialClassWithLogicalNotOperatorOverload
    {
        public abstract partial class Class
        {
            public static bool operator !(Class parameter1)
            {
                return default(bool);
            }
        }
    }
}

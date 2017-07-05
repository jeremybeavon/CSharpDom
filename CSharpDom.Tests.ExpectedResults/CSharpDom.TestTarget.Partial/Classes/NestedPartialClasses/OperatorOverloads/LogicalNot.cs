namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.OperatorOverloads
{
    public class ClassWithNestedPartialClassWithLogicalNotOperatorOverload
    {
        public partial class Class
        {
            public static bool operator !(Class parameter1)
            {
                return default(bool);
            }
        }
    }
}

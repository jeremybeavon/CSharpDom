namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.OperatorOverloads
{
    public class ClassWithNestedSealedPartialClassWithLogicalNotOperatorOverload
    {
        public sealed partial class Class
        {
            public static bool operator !(Class parameter1)
            {
                return default(bool);
            }
        }
    }
}

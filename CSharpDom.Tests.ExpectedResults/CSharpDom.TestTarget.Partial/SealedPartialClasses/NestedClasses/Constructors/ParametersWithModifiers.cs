namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Constructors
{
    public sealed partial class SealedPartialClassWithNestedClassWithConstructorWithParametersWithModifiers
    {
        public class Class
        {
            public Class(ref string text, out int integer, params object[] objects)
            {
                integer = default(int);
            }
        }
    }
}

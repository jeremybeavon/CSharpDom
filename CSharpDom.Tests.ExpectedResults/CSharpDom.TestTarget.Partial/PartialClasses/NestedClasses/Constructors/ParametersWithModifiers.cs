namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Constructors
{
    public partial class PartialClassWithNestedClassWithConstructorWithParametersWithModifiers
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

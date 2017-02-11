using CSharpDom.TestTarget.Classes.NestedStaticClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStaticClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedStaticClassWithInternalPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPrivatePropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPublicPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithPublicProperty));
        }
    }
}

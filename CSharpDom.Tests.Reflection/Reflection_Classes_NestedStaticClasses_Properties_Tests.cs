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
            TestClassAsync(typeof(ClassWithNestedStaticClassWithInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPrivatePropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPublicPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithPublicProperty));
        }
    }
}

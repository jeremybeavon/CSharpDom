using CSharpDom.TestTarget.Classes.NestedStaticClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStaticClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedStaticClassWithInternalAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPrivateAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPublicAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithPublicAutoProperty));
        }
    }
}

using CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedStaticClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithInternalPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStaticClassWithInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithPrivatePropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStaticClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithPublicPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStaticClassWithPublicProperty));
        }
    }
}

using CSharpDom.TestTarget.SealedClasses.NestedStructs.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedStructs_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStructWithInternalPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPrivatePropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithPrivateProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPublicPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithPublicProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithStaticPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithStaticProperty));
        }
    }
}

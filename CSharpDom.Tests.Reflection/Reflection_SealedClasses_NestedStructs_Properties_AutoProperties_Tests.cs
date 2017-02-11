using CSharpDom.TestTarget.SealedClasses.NestedStructs.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedStructs_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStructWithInternalAutoPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPrivateAutoPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPublicAutoPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithStaticAutoPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithStaticAutoProperty));
        }
    }
}

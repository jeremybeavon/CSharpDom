using CSharpDom.TestTarget.SealedClasses.NestedStructs.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedStructs_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStructWithInternalAutoPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPrivateAutoPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPublicAutoPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithStaticAutoPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithStaticAutoProperty));
        }
    }
}

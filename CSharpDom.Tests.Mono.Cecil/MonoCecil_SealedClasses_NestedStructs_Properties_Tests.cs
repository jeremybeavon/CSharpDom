using CSharpDom.TestTarget.SealedClasses.NestedStructs.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedStructs_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStructWithInternalPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPrivatePropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPublicPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithStaticPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithStaticProperty));
        }
    }
}

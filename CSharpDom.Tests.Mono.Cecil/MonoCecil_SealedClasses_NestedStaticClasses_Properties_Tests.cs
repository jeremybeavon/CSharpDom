using CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedStaticClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithInternalPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStaticClassWithInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithPrivatePropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStaticClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithPublicPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStaticClassWithPublicProperty));
        }
    }
}

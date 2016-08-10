using CSharpDom.TestTarget.AbstractClasses.NestedStructs.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedStructs_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedStructWithInternalAutoPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPrivateAutoPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPublicAutoPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithStaticAutoPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithStaticAutoProperty));
        }
    }
}

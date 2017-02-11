using CSharpDom.TestTarget.AbstractClasses.NestedStructs.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedStructs_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedStructWithInternalPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPrivatePropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithPrivateProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPublicPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithPublicProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithStaticPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithStaticProperty));
        }
    }
}

using CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedStaticClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithInternalPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStaticClassWithInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithPrivatePropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStaticClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithPublicPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStaticClassWithPublicProperty));
        }
    }
}

using CSharpDom.TestTarget.AbstractClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedEnums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedEnumWith1AttributeUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalNestedEnumUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateNestedEnumUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedNestedEnumUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicNestedEnumUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithPublicNestedEnum));
        }
    }
}

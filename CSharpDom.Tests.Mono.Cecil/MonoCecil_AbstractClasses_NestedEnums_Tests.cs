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
            TestAbstractClassAsync(typeof(AbstractClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalNestedEnumUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateNestedEnumUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedNestedEnumUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicNestedEnumUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPublicNestedEnum));
        }
    }
}

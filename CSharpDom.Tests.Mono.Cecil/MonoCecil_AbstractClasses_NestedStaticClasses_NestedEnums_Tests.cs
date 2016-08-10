using CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedStaticClasses_NestedEnums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedEnumWith1AttributeUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithInternalNestedEnumUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithPrivateNestedEnumUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithProtectedNestedEnumUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithPublicNestedEnumUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPublicNestedEnum));
        }
    }
}

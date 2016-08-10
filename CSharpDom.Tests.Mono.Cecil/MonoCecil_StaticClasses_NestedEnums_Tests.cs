using CSharpDom.TestTarget.StaticClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedEnums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedEnumWith1AttributeUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithInternalNestedEnumUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithPrivateNestedEnumUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithProtectedNestedEnumUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithPublicNestedEnumUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithPublicNestedEnum));
        }
    }
}

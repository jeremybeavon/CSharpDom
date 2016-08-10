using CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedStaticClasses_NestedEnums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedEnumWith1AttributeUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithInternalNestedEnumUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithPrivateNestedEnumUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithProtectedNestedEnumUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithPublicNestedEnumUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPublicNestedEnum));
        }
    }
}

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
            TestStaticClass(typeof(StaticClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithInternalNestedEnumUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithPrivateNestedEnumUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithProtectedNestedEnumUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithPublicNestedEnumUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithPublicNestedEnum));
        }
    }
}

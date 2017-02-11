using CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedClasses_NestedEnums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedEnumWith1AttributeUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalNestedEnumUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateNestedEnumUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedNestedEnumUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicNestedEnumUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPublicNestedEnum));
        }
    }
}

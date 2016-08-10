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
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalNestedEnumUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateNestedEnumUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedNestedEnumUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicNestedEnumUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicNestedEnum));
        }
    }
}

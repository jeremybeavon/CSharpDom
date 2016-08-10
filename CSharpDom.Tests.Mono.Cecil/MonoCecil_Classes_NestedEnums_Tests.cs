using CSharpDom.TestTarget.Classes.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedEnums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedEnumWith1AttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithPrivateNestedEnumUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestClassWithProtectedNestedEnumUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithInternalNestedEnumUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithPublicNestedEnumUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithPublicNestedEnum));
        }
    }
}

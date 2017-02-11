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
            TestClass(typeof(ClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithPrivateNestedEnumUsingMonoCecil()
        {
            TestClass(typeof(ClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestClassWithProtectedNestedEnumUsingMonoCecil()
        {
            TestClass(typeof(ClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            TestClass(typeof(ClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithInternalNestedEnumUsingMonoCecil()
        {
            TestClass(typeof(ClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithPublicNestedEnumUsingMonoCecil()
        {
            TestClass(typeof(ClassWithPublicNestedEnum));
        }
    }
}

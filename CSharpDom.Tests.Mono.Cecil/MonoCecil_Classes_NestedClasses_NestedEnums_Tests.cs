using CSharpDom.TestTarget.Classes.NestedClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedClasses_NestedEnums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithNestedEnumWith1AttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalNestedEnumUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateNestedEnumUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedNestedEnumUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicNestedEnumUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithPublicNestedEnum));
        }
    }
}

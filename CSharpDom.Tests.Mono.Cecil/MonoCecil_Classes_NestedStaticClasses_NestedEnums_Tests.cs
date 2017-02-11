using CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStaticClasses_NestedEnums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedEnumWith1AttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithInternalNestedEnumUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPrivateNestedEnumUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithProtectedNestedEnumUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPublicNestedEnumUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithPublicNestedEnum));
        }
    }
}

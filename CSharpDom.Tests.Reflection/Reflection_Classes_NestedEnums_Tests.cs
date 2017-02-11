using CSharpDom.TestTarget.Classes.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedEnums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedEnumWith1AttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithPrivateNestedEnumUsingReflection()
        {
            TestClass(typeof(ClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestClassWithProtectedNestedEnumUsingReflection()
        {
            TestClass(typeof(ClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalNestedEnumUsingReflection()
        {
            TestClass(typeof(ClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithInternalNestedEnumUsingReflection()
        {
            TestClass(typeof(ClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithPublicNestedEnumUsingReflection()
        {
            TestClass(typeof(ClassWithPublicNestedEnum));
        }
    }
}

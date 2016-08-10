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
            TestClassAsync(typeof(ClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithPrivateNestedEnumUsingReflection()
        {
            TestClassAsync(typeof(ClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestClassWithProtectedNestedEnumUsingReflection()
        {
            TestClassAsync(typeof(ClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalNestedEnumUsingReflection()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithInternalNestedEnumUsingReflection()
        {
            TestClassAsync(typeof(ClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithPublicNestedEnumUsingReflection()
        {
            TestClassAsync(typeof(ClassWithPublicNestedEnum));
        }
    }
}

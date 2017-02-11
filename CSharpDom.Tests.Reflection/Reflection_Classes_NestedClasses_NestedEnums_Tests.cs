using CSharpDom.TestTarget.Classes.NestedClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedClasses_NestedEnums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithNestedEnumWith1AttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalNestedEnumUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateNestedEnumUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedNestedEnumUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalNestedEnumUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicNestedEnumUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithPublicNestedEnum));
        }
    }
}

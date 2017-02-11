using CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStaticClasses_NestedEnums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedEnumWith1AttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithInternalNestedEnumUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPrivateNestedEnumUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithProtectedNestedEnumUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithProtectedInternalNestedEnumUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPublicNestedEnumUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithPublicNestedEnum));
        }
    }
}

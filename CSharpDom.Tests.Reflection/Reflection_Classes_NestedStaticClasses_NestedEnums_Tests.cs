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
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithInternalNestedEnumUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPrivateNestedEnumUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithProtectedNestedEnumUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithProtectedInternalNestedEnumUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPublicNestedEnumUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithPublicNestedEnum));
        }
    }
}

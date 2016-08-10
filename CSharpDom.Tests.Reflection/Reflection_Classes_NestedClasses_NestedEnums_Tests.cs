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
            TestClassAsync(typeof(ClassWithNestedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalNestedEnumUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateNestedEnumUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedNestedEnumUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalNestedEnumUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicNestedEnumUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPublicNestedEnum));
        }
    }
}

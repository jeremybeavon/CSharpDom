using CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedAbstractClasses_NestedEnums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNestedEnumWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithInternalNestedEnumUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPrivateNestedEnumUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedNestedEnumUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedInternalNestedEnumUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPublicNestedEnumUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicNestedEnum));
        }
    }
}

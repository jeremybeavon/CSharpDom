using CSharpDom.TestTarget.AbstractClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedEnums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedEnumWith1AttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalNestedEnumUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateNestedEnumUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedNestedEnumUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalNestedEnumUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicNestedEnumUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPublicNestedEnum));
        }
    }
}

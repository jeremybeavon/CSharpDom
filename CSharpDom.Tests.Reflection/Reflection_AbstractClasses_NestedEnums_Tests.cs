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
            TestAbstractClass(typeof(AbstractClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalNestedEnumUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateNestedEnumUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedNestedEnumUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalNestedEnumUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicNestedEnumUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithPublicNestedEnum));
        }
    }
}

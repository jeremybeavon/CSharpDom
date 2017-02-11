using CSharpDom.TestTarget.Classes.NestedStructs.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStructs_NestedEnums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithNestedEnumWith1AttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalNestedEnumUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateNestedEnumUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicNestedEnumUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithPublicNestedEnum));
        }
    }
}

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
            TestClassAsync(typeof(ClassWithNestedStructWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalNestedEnumUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateNestedEnumUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicNestedEnumUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPublicNestedEnum));
        }
    }
}

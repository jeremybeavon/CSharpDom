using CSharpDom.TestTarget.Classes.NestedStructs.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStructs_NestedEnums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithNestedEnumWith1AttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalNestedEnumUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateNestedEnumUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicNestedEnumUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithPublicNestedEnum));
        }
    }
}

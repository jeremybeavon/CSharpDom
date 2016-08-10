using CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStaticClasses_NestedEnums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedEnumWith1AttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithInternalNestedEnumUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPrivateNestedEnumUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithProtectedNestedEnumUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPublicNestedEnumUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithPublicNestedEnum));
        }
    }
}

using CSharpDom.TestTarget.Classes.NestedClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedClasses_NestedEnums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithNestedEnumWith1AttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalNestedEnumUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateNestedEnumUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedNestedEnumUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicNestedEnumUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPublicNestedEnum));
        }
    }
}

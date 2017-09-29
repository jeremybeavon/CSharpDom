using CSharpDom.TestTarget.Classes.NestedClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedClasses_NestedEnums_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithNestedEnumWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalNestedEnumUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateNestedEnumUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedNestedEnumUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalNestedEnumUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicNestedEnumUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPublicNestedEnum));
        }
    }
}

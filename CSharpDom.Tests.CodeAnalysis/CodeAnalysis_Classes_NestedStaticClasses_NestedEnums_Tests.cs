using CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedStaticClasses_NestedEnums_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedEnumWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithInternalNestedEnumUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPrivateNestedEnumUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithProtectedNestedEnumUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithProtectedInternalNestedEnumUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPublicNestedEnumUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithPublicNestedEnum));
        }
    }
}

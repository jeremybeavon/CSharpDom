using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedAbstractClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewVirtualPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOverridePropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivatePropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVirtualPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithVirtualProperty));
        }
    }
}

using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedAbstractClasses_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewVirtualAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithSealedOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVirtualAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithVirtualAutoProperty));
        }
    }
}

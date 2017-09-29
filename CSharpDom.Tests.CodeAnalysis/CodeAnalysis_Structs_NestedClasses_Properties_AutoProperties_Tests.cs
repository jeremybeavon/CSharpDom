using CSharpDom.TestTarget.Structs.NestedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewVirtualAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithSealedOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVirtualAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithVirtualAutoProperty));
        }
    }
}

using CSharpDom.TestTarget.Structs.NestedSealedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedSealedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithSealedOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithStaticAutoProperty));
        }
    }
}

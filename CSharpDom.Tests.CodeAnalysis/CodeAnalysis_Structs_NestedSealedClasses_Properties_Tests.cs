using CSharpDom.TestTarget.Structs.NestedSealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedSealedClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOverridePropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivatePropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithStaticProperty));
        }
    }
}

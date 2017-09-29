using CSharpDom.TestTarget.Structs.NestedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithInternalPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewVirtualPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithOverridePropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivatePropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVirtualPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithVirtualProperty));
        }
    }
}

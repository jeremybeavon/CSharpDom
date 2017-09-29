using CSharpDom.TestTarget.Classes.NestedSealedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedSealedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithSealedOverrideAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticAutoProperty));
        }
    }
}

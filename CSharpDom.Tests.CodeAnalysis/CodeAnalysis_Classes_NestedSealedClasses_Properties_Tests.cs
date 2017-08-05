using CSharpDom.TestTarget.Classes.NestedSealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedSealedClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithInternalPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithOverridePropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPrivatePropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPublicPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithStaticPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticProperty));
        }
    }
}

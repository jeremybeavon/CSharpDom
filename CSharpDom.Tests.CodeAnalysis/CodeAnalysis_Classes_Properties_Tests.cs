using CSharpDom.TestTarget.Classes.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithInternalPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithNewPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestClassWithNewVirtualPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNewVirtualProperty));
        }

        [TestMethod]
        public async Task TestClassWithOverridePropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestClassWithPrivatePropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestClassWithProtectedPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithPublicPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestClassWithStaticPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithStaticProperty));
        }

        [TestMethod]
        public async Task TestClassWithVirtualPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithVirtualProperty));
        }
    }
}

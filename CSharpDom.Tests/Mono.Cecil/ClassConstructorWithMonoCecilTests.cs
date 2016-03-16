using CSharpDom.Common;
using CSharpDom.Mono.Cecil;
using CSharpDom.Mono.Cecil.Internal;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.Classes;
using CSharpDom.TestTarget.Classes.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mono.Cecil;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public class ClassConstructorWithMonoCecilTests : AbstractSolutionTests<ProjectWithMonoCecil>
    {
        private ISolution<ProjectWithMonoCecil> solution;

        public override ISolution<ProjectWithMonoCecil> Solution
        {
            get { return solution; }
        }

        protected override bool IsConstructorTest
        {
            get { return true; }
        }

        [TestInitialize]
        public void SetUp()
        {
            solution = new AssemblyWithMonoCecil(AssemblyDefinition.ReadAssembly(typeof(PublicClass).Assembly.Location)).AsSolution();
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithPublicConstructorAsync()
        {
            await TestClassAsync(typeof(ClassWithPublicConstructor));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithInternalConstructorAsync()
        {
            await TestClassAsync(typeof(ClassWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithProtectedInternalConstructorAsync()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithProtectedConstructorAsync()
        {
            await TestClassAsync(typeof(ClassWithProtectedConstructor));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithPrivateConstructorAsync()
        {
            await TestClassAsync(typeof(ClassWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithConstructorWith1ParameterAsync()
        {
            await TestClassAsync(typeof(ClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithConstructorWith2ParametersAsync()
        {
            await TestClassAsync(typeof(ClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithConstructorWithParametersWithModifiersAsync()
        {
            await TestClassAsync(typeof(ClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithConstructorWith1AttributeAsync()
        {
            await TestClassAsync(typeof(ClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithConstructorWith2AttributesIn2AttributeGroupsAsync()
        {
            await TestClassAsync(typeof(ClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithConstructorWithParametersWithAttributesAsync()
        {
            await TestClassAsync(typeof(ClassWithConstructorWithParametersWithAttributes));
        }
    }
}

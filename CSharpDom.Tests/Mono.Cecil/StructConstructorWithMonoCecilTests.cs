using CSharpDom.Common;
using CSharpDom.Mono.Cecil;
using CSharpDom.Mono.Cecil.Internal;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.Structs;
using CSharpDom.TestTarget.Structs.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    /*[TestClass]
    public class StructConstructorWithMonoCecilTests : AbstractSolutionTests<ProjectWithMonoCecil>
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
            solution = new AssemblyWithMonoCecil(typeof(PublicStruct).Assembly).AsSolution();
        }

        [TestMethod]
        public async Task TestStructWithMonoCecilWithPublicConstructorAsync()
        {
            await TestStructAsync(typeof(StructWithPublicConstructor));
        }

        [TestMethod]
        public async Task TestStructWithMonoCecilWithInternalConstructorAsync()
        {
            await TestStructAsync(typeof(StructWithInternalConstructor));
        }
        
        [TestMethod]
        public async Task TestStructWithMonoCecilWithPrivateConstructorAsync()
        {
            await TestStructAsync(typeof(StructWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestStructWithMonoCecilWithConstructorWith1ParameterAsync()
        {
            await TestStructAsync(typeof(StructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestStructWithMonoCecilWithConstructorWith2ParametersAsync()
        {
            await TestStructAsync(typeof(StructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestStructWithMonoCecilWithConstructorWithParametersWithModifiersAsync()
        {
            await TestStructAsync(typeof(StructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStructWithMonoCecilWithConstructorWith1AttributeAsync()
        {
            await TestStructAsync(typeof(StructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestStructWithMonoCecilWithConstructorWith2AttributesIn2AttributeGroupsAsync()
        {
            await TestStructAsync(typeof(StructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithMonoCecilWithConstructorWithParametersWithAttributesAsync()
        {
            await TestStructAsync(typeof(StructWithConstructorWithParametersWithAttributes));
        }
    }*/
}

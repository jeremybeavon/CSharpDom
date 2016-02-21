using CSharpDom.Common;
using CSharpDom.Reflection;
using CSharpDom.Reflection.Internal;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.Structs;
using CSharpDom.TestTarget.Structs.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    /*[TestClass]
    public class StructConstructorWithReflectionTests : AbstractSolutionTests<ProjectWithReflection>
    {
        private ISolution<ProjectWithReflection> solution;

        public override ISolution<ProjectWithReflection> Solution
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
            solution = new AssemblyWithReflection(typeof(PublicStruct).Assembly).AsSolution();
        }

        [TestMethod]
        public async Task TestStructWithReflectionWithPublicConstructorAsync()
        {
            await TestStructAsync(typeof(StructWithPublicConstructor));
        }

        [TestMethod]
        public async Task TestStructWithReflectionWithInternalConstructorAsync()
        {
            await TestStructAsync(typeof(StructWithInternalConstructor));
        }
        
        [TestMethod]
        public async Task TestStructWithReflectionWithPrivateConstructorAsync()
        {
            await TestStructAsync(typeof(StructWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestStructWithReflectionWithConstructorWith1ParameterAsync()
        {
            await TestStructAsync(typeof(StructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestStructWithReflectionWithConstructorWith2ParametersAsync()
        {
            await TestStructAsync(typeof(StructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestStructWithReflectionWithConstructorWithParametersWithModifiersAsync()
        {
            await TestStructAsync(typeof(StructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStructWithReflectionWithConstructorWith1AttributeAsync()
        {
            await TestStructAsync(typeof(StructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestStructWithReflectionWithConstructorWith2AttributesIn2AttributeGroupsAsync()
        {
            await TestStructAsync(typeof(StructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithReflectionWithConstructorWithParametersWithAttributesAsync()
        {
            await TestStructAsync(typeof(StructWithConstructorWithParametersWithAttributes));
        }
    }*/
}

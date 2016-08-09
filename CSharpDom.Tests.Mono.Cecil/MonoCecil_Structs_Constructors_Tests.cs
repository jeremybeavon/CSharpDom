using CSharpDom.TestTarget.Structs.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        public MonoCecil_Structs_Constructors_Tests()
        {
            IsConstructorTest = true;
        }

        [TestMethod]
        public async Task TestStructWithConstructorWith1AttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithConstructorWith1ParameterUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestStructWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithConstructorWith2ParametersUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestStructWithInternalConstructorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestStructWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStructWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStructWithPrivateConstructorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestStructWithPublicConstructorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithPublicConstructor));
        }
    }
}

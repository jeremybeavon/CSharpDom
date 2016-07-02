using CSharpDom.TestTarget.Structs.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithConstructorWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithConstructorWith1ParameterUsingReflection()
        {
            await TestStructAsync(typeof(StructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestStructWithConstructorWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithConstructorWith2ParametersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestStructWithInternalConstructorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestStructWithConstructorWithParametersWithAttributesUsingReflection()
        {
            await TestStructAsync(typeof(StructWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStructWithConstructorWithParametersWithModifiersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStructWithPrivateConstructorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestStructWithPublicConstructorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithPublicConstructor));
        }
    }
}

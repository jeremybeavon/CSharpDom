using CSharpDom.TestTarget.Classes.NestedStructs.ConversionOperators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStructs_ConversionOperators_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitConversionOperatorUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitConversionOperator));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitConversionOperatorWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitConversionOperatorWith1ParameterAttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitConversionOperatorWith1ReturnAttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitConversionOperatorWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithImplicitConversionOperatorUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithImplicitConversionOperator));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithImplicitConversionOperatorWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithImplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithImplicitConversionOperatorWith1ParameterAttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithImplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithImplicitConversionOperatorWith1ReturnAttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithImplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithImplicitConversionOperatorWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }
    }
}

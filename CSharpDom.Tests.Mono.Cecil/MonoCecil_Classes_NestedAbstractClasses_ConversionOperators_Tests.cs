using CSharpDom.TestTarget.Classes.NestedAbstractClasses.ConversionOperators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedAbstractClasses_ConversionOperators_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithExplicitConversionOperatorUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitConversionOperator));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithExplicitConversionOperatorWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithExplicitConversionOperatorWith1ParameterAttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithExplicitConversionOperatorWith1ReturnAttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithImplicitConversionOperatorUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithImplicitConversionOperator));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithImplicitConversionOperatorWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithImplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithImplicitConversionOperatorWith1ParameterAttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithImplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithImplicitConversionOperatorWith1ReturnAttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithImplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }
    }
}

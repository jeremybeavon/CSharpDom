using CSharpDom.TestTarget.Classes.NestedSealedClasses.ConversionOperators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    public sealed partial class ClassNestedSealedClassWithReflectionTests
    {

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithExplicitConversionOperator()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitConversionOperator));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithExplicitConversionOperatorWith1Attribute()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithExplicitConversionOperatorWith1ParameterAttribute()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithExplicitConversionOperatorWith1ReturnAttribute()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithImplicitConversionOperator()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithImplicitConversionOperator));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithImplicitConversionOperatorWith1Attribute()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithImplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithImplicitConversionOperatorWith1ParameterAttribute()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithImplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithImplicitConversionOperatorWith1ReturnAttribute()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithImplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }
    }
}
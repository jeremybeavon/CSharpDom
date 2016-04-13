using CSharpDom.TestTarget.Classes.NestedClasses.ConversionOperators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    public sealed partial class ClassNestedClassWithReflectionTests
    {

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithExplicitConversionOperator()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitConversionOperator));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithExplicitConversionOperatorWith1Attribute()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithExplicitConversionOperatorWith1ParameterAttribute()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithExplicitConversionOperatorWith1ReturnAttribute()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithImplicitConversionOperator()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithImplicitConversionOperator));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithImplicitConversionOperatorWith1Attribute()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithImplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithImplicitConversionOperatorWith1ParameterAttribute()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithImplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithImplicitConversionOperatorWith1ReturnAttribute()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithImplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }
    }
}
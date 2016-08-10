using CSharpDom.TestTarget.AbstractClasses.ConversionOperators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_ConversionOperators_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithExplicitConversionOperatorUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithExplicitConversionOperator));
        }

        [TestMethod]
        public void TestAbstractClassWithExplicitConversionOperatorWith1AttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithExplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithExplicitConversionOperatorWith1ParameterAttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithExplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithExplicitConversionOperatorWith1ReturnAttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithExplicitConversionOperatorWith1ReturnAttribute));
        }
        
        [TestMethod]
        public void TestAbstractClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }
        
        [TestMethod]
        public void TestAbstractClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithImplicitConversionOperatorUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithImplicitConversionOperator));
        }

        [TestMethod]
        public void TestAbstractClassWithImplicitConversionOperatorWith1AttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithImplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithImplicitConversionOperatorWith1ParameterAttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithImplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithImplicitConversionOperatorWith1ReturnAttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithImplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }
    }
}

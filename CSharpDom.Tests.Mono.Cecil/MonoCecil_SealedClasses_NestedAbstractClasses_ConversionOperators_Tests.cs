using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.ConversionOperators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedAbstractClasses_ConversionOperators_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithExplicitConversionOperatorUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithExplicitConversionOperator));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith1AttributeUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith1ParameterAttributeUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith1ReturnAttributeUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithImplicitConversionOperatorUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithImplicitConversionOperator));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithImplicitConversionOperatorWith1AttributeUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithImplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithImplicitConversionOperatorWith1ParameterAttributeUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithImplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithImplicitConversionOperatorWith1ReturnAttributeUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithImplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }
    }
}

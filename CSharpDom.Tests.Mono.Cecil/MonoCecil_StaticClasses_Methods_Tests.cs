using CSharpDom.TestTarget.StaticClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_Methods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStaticClassWithMethodWith1AttributeUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWith1GenericParameterUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWith1ReturnAttributeUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWith2GenericParametersUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterBaseSealedClassConstraintUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterBaseSealedClassConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterSealedClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterSealedClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterSealedClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterSealedClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterSealedClassConstraintUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterSealedClassConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithInternalMethodUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithInternalMethod));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStaticClassWithMethodWithParametersWithModifiersUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStaticClassWithPrivateMethodUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestStaticClassWithPublicMethodUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithPublicMethod));
        }
    }
}

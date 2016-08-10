using CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedStaticClasses_Methods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithMethodWith1AttributeUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithMethodWith1GenericParameterUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithMethodWith1ReturnAttributeUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithMethodWith2GenericParametersUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithMethodWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithMethodWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithMethodWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithMethodWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithMethodWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithInternalMethodUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithInternalMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithMethodWithParametersWithModifiersUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithPrivateMethodUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithPublicMethodUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPublicMethod));
        }
    }
}

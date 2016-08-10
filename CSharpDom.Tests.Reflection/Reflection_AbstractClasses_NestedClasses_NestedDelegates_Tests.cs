using CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedClasses_NestedDelegates_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNestedDelegateWith1AttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNestedDelegateWith1GenericParameterUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNestedDelegateWith2GenericParametersUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNestedDelegateWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraintUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNestedDelegateWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNestedDelegateWithGenericParameterStructConstraintUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithInternalNestedDelegateUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalNestedDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNestedClassWithNestedDelegateWithParametersWithAttributesUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedClassWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNestedClassWithNestedDelegateWithParametersWithModifiersUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedClassWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivateNestedDelegateUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateNestedDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedNestedDelegateUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedNestedDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalNestedDelegateUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalNestedDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicNestedDelegateUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicNestedDelegate));
        }
    }
}

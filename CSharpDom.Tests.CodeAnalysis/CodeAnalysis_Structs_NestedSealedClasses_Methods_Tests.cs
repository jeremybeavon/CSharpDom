using CSharpDom.TestTarget.Structs.NestedSealedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedSealedClasses_Methods_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWith1GenericParameterUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWith1ReturnAttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWith2GenericParametersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWith2ReturnAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalMethodUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithInternalMethod));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewMethodUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewMethod));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticMethodUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOverrideMethodUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateMethodUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedMethodUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalMethodUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicMethodUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPublicMethod));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithSealedOverrideMethodUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticMethodUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithStaticMethod));
        }
    }
}

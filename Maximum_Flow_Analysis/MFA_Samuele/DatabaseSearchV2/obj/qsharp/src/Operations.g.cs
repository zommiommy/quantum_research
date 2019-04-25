#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.DatabaseSearch\",\"Name\":\"DatabaseOracleFromInts\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/DatabaseSearchV2/Operations.qs\",\"Position\":{\"Item1\":45,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":49}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedQubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":70}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":80},\"Item2\":{\"Line\":1,\"Column\":96}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[\" # Summary\",\" Database oracle `D` constructed from classical database.\",\"\",\" # Input\",\" ## markedElements\",\" Indices to marked elements in database.\",\" ## markedQubit\",\" Qubit that indicated whether database element is marked.\",\" ## databaseRegister\",\" A register of n qubits initially in the |00…0〉 state.\",\"\",\" # Remarks\",\" This implements the oracle D |z〉 |k〉 = |z ⊕ xₖ〉 |k〉 used in the Grover\",\" search algorithm. xₖ is 1 if k is in \\\"markedElements\\\" and 0 otherwise.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.DatabaseSearch\",\"Name\":\"DatabaseOracleFromInts\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/DatabaseSearchV2/Operations.qs\",\"Position\":{\"Item1\":47,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.DatabaseSearch\",\"Name\":\"DatabaseOracleFromInts\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/DatabaseSearchV2/Operations.qs\",\"Position\":{\"Item1\":59,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Quantum.DatabaseSearch\",\"Name\":\"DatabaseOracleFromInts\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/DatabaseSearchV2/Operations.qs\",\"Position\":{\"Item1\":60,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.DatabaseSearch\",\"Name\":\"DatabaseOracleFromInts\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/DatabaseSearchV2/Operations.qs\",\"Position\":{\"Item1\":61,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.DatabaseSearch\",\"Name\":\"GroverStatePrepOracleImpl\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/DatabaseSearchV2/Operations.qs\",\"Position\":{\"Item1\":87,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":52}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"idxMarkedQubit\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":62},\"Item2\":{\"Line\":1,\"Column\":76}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"startQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":84},\"Item2\":{\"Line\":1,\"Column\":95}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[\" # Summary\",\" Preparation of start state from database oracle and oracle `U` that\",\" creates a uniform superposition over database indices.\",\"\",\" # Input\",\" ## markedElements\",\" Indices to marked elements in database.\",\" ## idxMarkedQubit\",\" Index to `MarkedQubit`.\",\" ## startQubits\",\" The collection of the n+1 qubits `MarkedQubit` and `databaseRegister`\",\" initially in the |00…0〉 state.\",\"\",\" # Remarks\",\" This implements an oracle `DU` that prepares the start state\",\" DU|0〉|0〉 = √(M/N)|1〉|marked〉 + √(1-(M/N)^2)|0〉|unmarked〉 where\",\" `M` is the length of `markedElements`, and\",\" `N` is 2^n, where `n` is the number of database qubits.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.DatabaseSearch\",\"Name\":\"GroverStatePrepOracleImpl\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/DatabaseSearchV2/Operations.qs\",\"Position\":{\"Item1\":89,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.DatabaseSearch\",\"Name\":\"GroverStatePrepOracleImpl\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/DatabaseSearchV2/Operations.qs\",\"Position\":{\"Item1\":100,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Quantum.DatabaseSearch\",\"Name\":\"GroverStatePrepOracleImpl\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/DatabaseSearchV2/Operations.qs\",\"Position\":{\"Item1\":101,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.DatabaseSearch\",\"Name\":\"GroverStatePrepOracleImpl\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/DatabaseSearchV2/Operations.qs\",\"Position\":{\"Item1\":102,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Quantum.DatabaseSearch\",\"Name\":\"GroverStatePrepOracle\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/DatabaseSearchV2/Operations.qs\",\"Position\":{\"Item1\":118,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":47}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Canon\",\"Name\":\"StateOracle\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":70}}]}}]},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" `StateOracle` type for the preparation of a start state that has a\",\" marked qubit entangled with some desired state in the database\",\" register.\",\"\",\" # Input\",\" ## markedElements\",\" Indices to marked elements in database.\",\"\",\" # Output\",\" A `StateOracle` type with signature\",\" ((Int, Qubit[]) => (): Adjoint, Controlled).\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.DatabaseSearch\",\"Name\":\"GroverStatePrepOracle\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/DatabaseSearchV2/Operations.qs\",\"Position\":{\"Item1\":118,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Quantum.DatabaseSearch\",\"Name\":\"GroverSearch\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/DatabaseSearchV2/Operations.qs\",\"Position\":{\"Item1\":144,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":38}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nIterations\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":59}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"idxMarkedQubit\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":67},\"Item2\":{\"Line\":1,\"Column\":81}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]]},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Grover's search algorithm using library functions.\",\"\",\" # Input\",\" ## markedElements\",\" Indices to marked elements in database.\",\" ## nIterations\",\" Number of iterations of the Grover iteration to apply.\",\" ## idxMarkedQubit\",\" Index to `MarkedQubit`.\",\"\",\" # Output\",\" Unitary implementing Grover's search algorithm.\",\"\",\" # Remarks\",\" On input |0〉|0〉, this prepares the state |1〉|marked〉 with amplitude\",\" Sin((2*nIterations + 1) ArcSin(Sqrt(M/N))).\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.DatabaseSearch\",\"Name\":\"GroverSearch\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/DatabaseSearchV2/Operations.qs\",\"Position\":{\"Item1\":144,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.DatabaseSearch\",\"Name\":\"ApplyGroverSearch\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/DatabaseSearchV2/Operations.qs\",\"Position\":{\"Item1\":167,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedElements\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":44}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nIterations\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":65}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nDatabaseQubits\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":73},\"Item2\":{\"Line\":1,\"Column\":88}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Int\"}]]},\"SupportedFunctors\":[]},\"Documentation\":[\" # Summary\",\" Performs quantum search for the marked elements and returns an index\",\" to the found element in integer format.\",\"\",\" # Input\",\" ## markedElements\",\" Indices to marked elements in database.\",\" ## nIterations\",\" Number of applications of the Grover iterate (RS · RM).\",\" ## nDatabaseQubits\",\" Number of qubits in the database register.\",\"\",\" # Output\",\" Measurement outcome of marked Qubit and measurement outcomes of\",\" the database register converted to an integer.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.DatabaseSearch\",\"Name\":\"ApplyGroverSearch\"},\"SourceFile\":\"C:/Users/Samuele/Documents/GitHub/quantum_research/Maximum_Flow_Analysis/MFA_Samuele/DatabaseSearchV2/Operations.qs\",\"Position\":{\"Item1\":167,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.DatabaseSearch
{
    public class DatabaseOracleFromInts : Unitary<(QArray<Int64>,Qubit,QArray<Qubit>)>, ICallable
    {
        public DatabaseOracleFromInts(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,Qubit,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Int64>,Qubit,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "DatabaseOracleFromInts";
        String ICallable.FullName => "Quantum.DatabaseSearch.DatabaseOracleFromInts";
        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonControlledOnInt
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,Qubit,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (markedElements,markedQubit,databaseRegister) = __in__;
#line 49 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\DatabaseSearchV2\\Operations.qs"
            var nMarked = markedElements.Length;
#line 51 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\DatabaseSearchV2\\Operations.qs"
            foreach (var idxMarked in new Range(0L, (nMarked - 1L)))
#line hidden
            {
#line 56 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\DatabaseSearchV2\\Operations.qs"
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((markedElements[idxMarked], MicrosoftQuantumCanonApplyToEachCA.Partial(new Func<QArray<Qubit>, (IUnitary,QArray<Qubit>)>((__arg1__) => (MicrosoftQuantumPrimitiveX, __arg1__))))).Apply((databaseRegister?.Copy(), new QArray<Qubit>()
                {markedQubit}));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Int64>,Qubit,QArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (markedElements,markedQubit,databaseRegister) = __in__;
#line hidden
            var nMarked = markedElements.Length;
#line hidden
            foreach (var idxMarked in RangeReverse.Apply(new Range(0L, (nMarked - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((markedElements[idxMarked], MicrosoftQuantumCanonApplyToEachCA.Partial(new Func<QArray<Qubit>, (IUnitary,QArray<Qubit>)>((__arg1__) => (MicrosoftQuantumPrimitiveX, __arg1__))))).Adjoint.Apply((databaseRegister?.Copy(), new QArray<Qubit>()
                {markedQubit}));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Int64>,Qubit,QArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(markedElements,markedQubit,databaseRegister)) = __in__;
#line hidden
            var nMarked = markedElements.Length;
#line hidden
            foreach (var idxMarked in new Range(0L, (nMarked - 1L)))
#line hidden
            {
#line hidden
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((markedElements[idxMarked], MicrosoftQuantumCanonApplyToEachCA.Partial(new Func<QArray<Qubit>, (IUnitary,QArray<Qubit>)>((__arg1__) => (MicrosoftQuantumPrimitiveX, __arg1__))))).Controlled.Apply((__controlQubits__?.Copy(), (databaseRegister?.Copy(), new QArray<Qubit>()
                {markedQubit})));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Int64>,Qubit,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(markedElements,markedQubit,databaseRegister)) = __in__;
#line hidden
            var nMarked = markedElements.Length;
#line hidden
            foreach (var idxMarked in RangeReverse.Apply(new Range(0L, (nMarked - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((markedElements[idxMarked], MicrosoftQuantumCanonApplyToEachCA.Partial(new Func<QArray<Qubit>, (IUnitary,QArray<Qubit>)>((__arg1__) => (MicrosoftQuantumPrimitiveX, __arg1__))))).Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (databaseRegister?.Copy(), new QArray<Qubit>()
                {markedQubit})));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.MicrosoftQuantumCanonControlledOnInt = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnInt<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Int64>,Qubit,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Int64> markedElements, Qubit markedQubit, QArray<Qubit> databaseRegister)
        {
            return __m__.Run<DatabaseOracleFromInts, (QArray<Int64>,Qubit,QArray<Qubit>), QVoid>((markedElements, markedQubit, databaseRegister));
        }
    }

    public class GroverStatePrepOracleImpl : Unitary<(QArray<Int64>,Int64,QArray<Qubit>)>, ICallable
    {
        public GroverStatePrepOracleImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,Int64,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Int64>,Int64,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item3)?.Qubits;
        }

        String ICallable.Name => "GroverStatePrepOracleImpl";
        String ICallable.FullName => "Quantum.DatabaseSearch.GroverStatePrepOracleImpl";
        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonExclude
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Int64>,Qubit,QArray<Qubit>)> DatabaseOracleFromInts
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,Int64,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (markedElements,idxMarkedQubit,startQubits) = __in__;
#line 91 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\DatabaseSearchV2\\Operations.qs"
            var flagQubit = startQubits[idxMarkedQubit];
#line 92 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\DatabaseSearchV2\\Operations.qs"
            var databaseRegister = MicrosoftQuantumCanonExclude.Apply<QArray<Qubit>>((new QArray<Int64>()
            {idxMarkedQubit}, startQubits?.Copy()));
#line 95 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\DatabaseSearchV2\\Operations.qs"
            MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumPrimitiveH, databaseRegister?.Copy()));
#line 98 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\DatabaseSearchV2\\Operations.qs"
            DatabaseOracleFromInts.Apply((markedElements?.Copy(), flagQubit, databaseRegister?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Int64>,Int64,QArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (markedElements,idxMarkedQubit,startQubits) = __in__;
#line hidden
            var flagQubit = startQubits[idxMarkedQubit];
#line hidden
            var databaseRegister = MicrosoftQuantumCanonExclude.Apply<QArray<Qubit>>((new QArray<Int64>()
            {idxMarkedQubit}, startQubits?.Copy()));
#line hidden
            DatabaseOracleFromInts.Adjoint.Apply((markedElements?.Copy(), flagQubit, databaseRegister?.Copy()));
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumPrimitiveH, databaseRegister?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Int64>,Int64,QArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(markedElements,idxMarkedQubit,startQubits)) = __in__;
#line hidden
            var flagQubit = startQubits[idxMarkedQubit];
#line hidden
            var databaseRegister = MicrosoftQuantumCanonExclude.Apply<QArray<Qubit>>((new QArray<Int64>()
            {idxMarkedQubit}, startQubits?.Copy()));
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveH, databaseRegister?.Copy())));
#line hidden
            DatabaseOracleFromInts.Controlled.Apply((__controlQubits__?.Copy(), (markedElements?.Copy(), flagQubit, databaseRegister?.Copy())));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Int64>,Int64,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(markedElements,idxMarkedQubit,startQubits)) = __in__;
#line hidden
            var flagQubit = startQubits[idxMarkedQubit];
#line hidden
            var databaseRegister = MicrosoftQuantumCanonExclude.Apply<QArray<Qubit>>((new QArray<Int64>()
            {idxMarkedQubit}, startQubits?.Copy()));
#line hidden
            DatabaseOracleFromInts.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (markedElements?.Copy(), flagQubit, databaseRegister?.Copy())));
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveH, databaseRegister?.Copy())));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.MicrosoftQuantumCanonExclude = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Exclude<>));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.DatabaseOracleFromInts = this.Factory.Get<IUnitary<(QArray<Int64>,Qubit,QArray<Qubit>)>>(typeof(DatabaseOracleFromInts));
        }

        public override IApplyData __dataIn((QArray<Int64>,Int64,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Int64> markedElements, Int64 idxMarkedQubit, QArray<Qubit> startQubits)
        {
            return __m__.Run<GroverStatePrepOracleImpl, (QArray<Int64>,Int64,QArray<Qubit>), QVoid>((markedElements, idxMarkedQubit, startQubits));
        }
    }

    public class GroverStatePrepOracle : Function<QArray<Int64>, Microsoft.Quantum.Canon.StateOracle>, ICallable
    {
        public GroverStatePrepOracle(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GroverStatePrepOracle";
        String ICallable.FullName => "Quantum.DatabaseSearch.GroverStatePrepOracle";
        protected IUnitary<(QArray<Int64>,Int64,QArray<Qubit>)> GroverStatePrepOracleImpl
        {
            get;
            set;
        }

        public override Func<QArray<Int64>, Microsoft.Quantum.Canon.StateOracle> Body => (__in__) =>
        {
            var markedElements = __in__;
#line 121 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\DatabaseSearchV2\\Operations.qs"
            return new Microsoft.Quantum.Canon.StateOracle(GroverStatePrepOracleImpl.Partial(new Func<(Int64,QArray<Qubit>), (QArray<Int64>,Int64,QArray<Qubit>)>((__arg1__) => (markedElements?.Copy(), __arg1__.Item1, __arg1__.Item2))));
        }

        ;
        public override void Init()
        {
            this.GroverStatePrepOracleImpl = this.Factory.Get<IUnitary<(QArray<Int64>,Int64,QArray<Qubit>)>>(typeof(GroverStatePrepOracleImpl));
        }

        public override IApplyData __dataIn(QArray<Int64> data) => data;
        public override IApplyData __dataOut(Microsoft.Quantum.Canon.StateOracle data) => data;
        public static System.Threading.Tasks.Task<Microsoft.Quantum.Canon.StateOracle> Run(IOperationFactory __m__, QArray<Int64> markedElements)
        {
            return __m__.Run<GroverStatePrepOracle, QArray<Int64>, Microsoft.Quantum.Canon.StateOracle>(markedElements);
        }
    }

    public class GroverSearch : Function<(QArray<Int64>,Int64,Int64), IUnitary>, ICallable
    {
        public GroverSearch(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,Int64,Int64)>, IApplyData
        {
            public In((QArray<Int64>,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "GroverSearch";
        String ICallable.FullName => "Quantum.DatabaseSearch.GroverSearch";
        protected ICallable<(Int64,Microsoft.Quantum.Canon.StateOracle,Int64), IUnitary> MicrosoftQuantumCanonAmpAmpByOracle
        {
            get;
            set;
        }

        protected ICallable<QArray<Int64>, Microsoft.Quantum.Canon.StateOracle> GroverStatePrepOracle
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,Int64,Int64), IUnitary> Body => (__in__) =>
        {
            var (markedElements,nIterations,idxMarkedQubit) = __in__;
#line 147 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\DatabaseSearchV2\\Operations.qs"
            return MicrosoftQuantumCanonAmpAmpByOracle.Apply((nIterations, GroverStatePrepOracle.Apply(markedElements), idxMarkedQubit));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonAmpAmpByOracle = this.Factory.Get<ICallable<(Int64,Microsoft.Quantum.Canon.StateOracle,Int64), IUnitary>>(typeof(Microsoft.Quantum.Canon.AmpAmpByOracle));
            this.GroverStatePrepOracle = this.Factory.Get<ICallable<QArray<Int64>, Microsoft.Quantum.Canon.StateOracle>>(typeof(GroverStatePrepOracle));
        }

        public override IApplyData __dataIn((QArray<Int64>,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, QArray<Int64> markedElements, Int64 nIterations, Int64 idxMarkedQubit)
        {
            return __m__.Run<GroverSearch, (QArray<Int64>,Int64,Int64), IUnitary>((markedElements, nIterations, idxMarkedQubit));
        }
    }

    public class ApplyGroverSearch : Operation<(QArray<Int64>,Int64,Int64), (Result,Int64)>, ICallable
    {
        public ApplyGroverSearch(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,Int64,Int64)>, IApplyData
        {
            public In((QArray<Int64>,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(Result,Int64)>, IApplyData
        {
            public Out((Result,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "ApplyGroverSearch";
        String ICallable.FullName => "Quantum.DatabaseSearch.ApplyGroverSearch";
        protected ICallable<QArray<Qubit>, QArray<Result>> MicrosoftQuantumCanonMultiM
        {
            get;
            set;
        }

        protected ICallable<QArray<Result>, Int64> MicrosoftQuantumCanonPositiveIntFromResultArr
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected ICallable<(QArray<Int64>,Int64,Int64), IUnitary> GroverSearch
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,Int64,Int64), (Result,Int64)> Body => (__in__) =>
        {
            var (markedElements,nIterations,nDatabaseQubits) = __in__;
#line 171 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\DatabaseSearchV2\\Operations.qs"
            var resultSuccess = Result.Zero;
#line 172 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\DatabaseSearchV2\\Operations.qs"
            var numberElement = 0L;
#line hidden
            {
#line 176 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\DatabaseSearchV2\\Operations.qs"
                var qubits = Allocate.Apply((nDatabaseQubits + 1L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 179 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\DatabaseSearchV2\\Operations.qs"
                    var markedQubit = qubits[0L];
#line 182 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\DatabaseSearchV2\\Operations.qs"
                    var databaseRegister = qubits?.Slice(new Range(1L, nDatabaseQubits));
#line 185 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\DatabaseSearchV2\\Operations.qs"
                    GroverSearch.Apply((markedElements?.Copy(), nIterations, 0L)).Apply(qubits?.Copy());
#line 188 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\DatabaseSearchV2\\Operations.qs"
                    resultSuccess = M.Apply(markedQubit);
#line 192 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\DatabaseSearchV2\\Operations.qs"
                    var resultElement = MicrosoftQuantumCanonMultiM.Apply(databaseRegister?.Copy());
#line 193 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\DatabaseSearchV2\\Operations.qs"
                    numberElement = MicrosoftQuantumCanonPositiveIntFromResultArr.Apply(resultElement);
#line 197 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\DatabaseSearchV2\\Operations.qs"
                    ResetAll.Apply(qubits?.Copy());
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(qubits);
                }
            }

#line 201 "C:\\Users\\Samuele\\Documents\\GitHub\\quantum_research\\Maximum_Flow_Analysis\\MFA_Samuele\\DatabaseSearchV2\\Operations.qs"
            return (resultSuccess, numberElement);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonMultiM = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Result>>>(typeof(Microsoft.Quantum.Canon.MultiM));
            this.MicrosoftQuantumCanonPositiveIntFromResultArr = this.Factory.Get<ICallable<QArray<Result>, Int64>>(typeof(Microsoft.Quantum.Canon.PositiveIntFromResultArr));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.GroverSearch = this.Factory.Get<ICallable<(QArray<Int64>,Int64,Int64), IUnitary>>(typeof(GroverSearch));
        }

        public override IApplyData __dataIn((QArray<Int64>,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut((Result,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Result,Int64)> Run(IOperationFactory __m__, QArray<Int64> markedElements, Int64 nIterations, Int64 nDatabaseQubits)
        {
            return __m__.Run<ApplyGroverSearch, (QArray<Int64>,Int64,Int64), (Result,Int64)>((markedElements, nIterations, nDatabaseQubits));
        }
    }
}
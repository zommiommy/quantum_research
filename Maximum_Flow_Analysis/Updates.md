# Updates log

## 23/05/2019 - Samuele

*Abstract: ho un'idea di procedimento per permutare le righe di una matrice tramite quantum gates.*

### Octave

Ho scritto i seguenti codici che implementano operazioni elementari tra matrici:
- Pauli X, Y, Z
- Hadamard (H)
- CNOT
- SWAP
- CCNOT
- CSWAP

Ho definito delle nuove operazioni non elementari (derivate):
- DSWAP (double swap)
- ICNOT (inverse CNOT)
- CNOT3 (CNOT 8x8 != CCNOT)
- CNOT4 (CNOT 16x16 != CCCNOT)
- SWAP3 (SWAP 8x8 != CSWAP)
- SWAP4 (SWAP 16x16 != CCSWAP)
- SHIFT (scambia semimatrice sup con semimatrice inf)
- SHIFT3 (SHIFT 8x8)
- SHIFT4 (SHIFT 16x16)

Ho implementato la funzione *swap_rows_quantum()*, in grado di scambiare 2 righe arbitrarie di una matrice 4x4 (rappresentante 2bit) attraverso l'applicazione sequenziale delle porte logiche sopra definite.

Non dovrebbe essere troppo difficile implementare anche *swap_rows_quantum3* e *swap_rows_quantum4*, in grado di scambiare blocchi contigui da 2 e da 4 righe.

### Q\#

Ho implementato le operazioni
- DSWAP
- SHIFT
- ICNOT

E' molto semplice implementare anche tutte le altre operazioni sopra elencate, perché direttamente derivabili dai prodotti di kronecker.

### Algoritmo

#### Definizioni

- Sia N il numero di righe della matrice rappresentante un'operazione G. Il numero N è ovviamente 2^n, dove n è il numero di bit su cui si applica la porta G.
- Sia *kxk* la sottomatrice minima su cui una porta G agisce, cioè il blocco quadrato più piccolo in cui tutti gli elementi della matrice G sono uguali.

Chiamerò "grado" di una porta il numero log2(k).

*Esempi:*

- *Le porte CNOT e SWAP   hanno n=2, k=1, grado=0*
- *Le porte CNOT3 e SWAP3 hanno n=3, k=2, grado=1*
- *Le porte CNOT4 e SWAP4 hanno n=4, k=4, grado=2*
- *La porta CCNOT ha            n=3, k=1, grado=0*

Sì può facilmente aumentare di h il grado di una matrice G facendo kron(G,I), dove I è la matrice identità di dimensione 2^h.
Ciò equivale, in un registro grande n+h qubits, ad applicare G ai primi n qubits e non applicare nulla ai restanti h.

#### Ragionamento

Ho pensato ad un algoritmo per scambiare in modo arbitrario righe di una matrice 8x8 (3 bit).

Usando CNOT3, SWAP3 e ICNOT3 posso scambiare macroblocchi di matrice (blocchi di 2 righe contigue). Posso operare poi sui due blocchi (ognuno 2x8) della semimatrice inferiore usando le porte CCNOT, CSWAP e CICNOT, con granularità delle singole righe. Da notare che la CSWAP mi permette di scambiare due righe di due blocchi (2x8) diversi.

Lo stesso algoritmo si può utilizzare per matrici 16x16, aumentando di uno il grado di tutte le porte precedenti e aggiungendo alla collezione le porte CCCNOT, CCSWAP, CCICNOT.

#### Questioni irrisolte

Il ragionamento che sta alla base dell'algoritmo sembra funzionare, tuttavia la costruzione della porta CICNOT non è banale ma probabilmente fattibile, mentre la costruzione delle porte CCCNOT, CCSWAP, CCICNOT (ecc...) è probabilmente esponenzialmente più complessa ogni volta che si aggiunge una "C".

Una pagina di StackExchange sull'implementazione di CNOT e CCNOT (detta Toffoli Gate), e in generale di una qualsiasi altra porta "controlled": https://quantumcomputing.stackexchange.com/questions/3943/how-do-you-implement-the-toffoli-gate-using-only-single-qubit-and-cnot-gates

Ritengo comunque al di fuori degli scopi della mia ricerca trovare un'implementazione in porte elementari per la porta CICNOT.

Inoltre, sebbene congetturo di poter ottenere tutte le permutazioni possibili utilizzando solo il set di operazioni mostrate, non ne ho una dimostrazione, né un algoritmo che possa calcolare qual è la sequenza di operazioni da applicare per ottenere una permutazione arbitraria.

## 15/05/2019 - Samuele

Come anticipato nell'update precedente, il paper
https://apps.dtic.mil/dtic/tr/fulltext/u2/a559750.pdf
sembra essere quello che cercavamo.
Esso trova un modo per codificare gli elementi presenti in un database, come stati entangled di un registro. Quindi query casuali a questo registro restituirebbero solo i valori entangled.

Il registro-database viene creato moltiplicandolo per una matrice particolare in cui le righe sono scambiate in modo da codificare nella loro nuova posizione i dati.
Per ottenere questa matrice basta un operatore identitità I, un paio di porte H e una matrice che se la moltiplichi a qualcosa scambia semplicemente l'ordine delle righe di quel qualcosa.

Quest'ultima matrice non può essere ottenuta come prodotto di operatori semplici (H, I, X, Y, Z), ma deve essere implementata come porte logiche sui singoli bit in maniera più o meno complessa. L'obiettivo per adesso è capire se è possibile trovare la combinazione di porte logiche opportune per riprodurre una generica matrice di scambio righe oppure, se non si può automatizzare la cosa, una sua istanza specifica.

Vorrei provare ad implementare in Q# un esempio di semplice database e di ricerca in esso. Quindi un'istanza.

Tommaso mi ha fornito un paio di paper da leggere per l'implementazione di una matrice tramite porte:
http://home.lu.lv/~sd20008/papers/essays/Solovay-Kitaev.pdf
https://arxiv.org/pdf/quant-ph/0505030.pdf


## 12/05/2019 - Samuele

Un altro paper che skippa il problema con eleganza:
https://arxiv.org/pdf/quant-ph/0301079.pdf

> Suppose we have an unstructured database with N elements. Without loss of generality, suppose that the elements are numbers from 0 to N − 1.

No, non è vero, non c'è informazione in un insieme con tutti i possibili valori. Dato un numero n di bit, un database i cui elementi sono stringhe lunghe tutte n bit ha senso solo se non rientra nei 2 casi banali: database vuoto o database con tutte le possibili combinazioni.
Chiaramente la ricerca di un elemento nel primo caso fallirà sempre. Nel secondo caso la ricerca ha senso solo se viene restituita la posizione dell'elemento, cosa che non succede qui, in quanto l'algoritmo è progettato per trovare il numero che soddisfa una funzione, non la sua posizione in una lista.

Ciliegina sulla torta, si può trovare la stessa omissione di spiegazioni nel paper originale scritto dal sig Grover (che per inciso ho letto tutto)
https://arxiv.org/pdf/quant-ph/9605043.pdf
dopo aver promesso applicazioni dell'algoritmo come cercare un numero nella rubrica telefonica tramite il nome, anche questo paper non fa altro che limitarsi a cercare tra i numeri da 0 a 2^n-1

--

**No va beh, FERMI TUTTI, forse ho trovato quello che cercavo**
https://apps.dtic.mil/dtic/tr/fulltext/u2/a559750.pdf


## 09/05/2019 - Samuele

Mi sono informato un po' di più sugli **spatial database**, per capire se potevano essere utili a modellare un grafo con costi arbitrari sugli archi.

Queste sono le risorse che ho letto:
- https://en.wikipedia.org/wiki/Spatial_database#Features_of_spatial_databases
- https://www.tutorialspoint.com/Spatial-Databases
- https://web.engr.oregonstate.edu/~erwig/papers/XGraphsInSpatialDB_REPORT.pdf

Non sono però riuscito a trovare un collegamento evidente tra le due cose.

Ho anche letto materiale su **Random Walk** e **Quantum Walk** su grafi:

- **Quantum Walks on Graphs** (https://arxiv.org/pdf/quant-ph/0012090.pdf)
> We set the ground for a theory of quantum walks on graphs the generalization of random walks on finite graphs to the quantum world.

- **Spatial search by quantum walk** (https://arxiv.org/pdf/quant-ph/0306054.pdf)
> Grover’s quantum search algorithm provides a way to speed up combinatorial search, but is not directly applicable to searching a physical database. [...] We consider an alternative search algorithm based on a continuous time quantum walk on a graph.

Nonostante i punti di contatto con Grover siano molteplici, nessuno di questi mi è sembrato di una qualche utilità per il nostro algoritmo di Max Flow Analysis.


## 08/05/ - Samuele

Sotto suggerimento della prof Di Nitto, ho consultato il sito http://quantumalgorithmzoo.org/. Tra i vari algoritmi, ho selezionato quelli che menzionano il searching. Di seguito ricopio commento le parti rilevanti.

#### Searching (Grover)

> **Speedup:** Polynomial 
**Description:** We are given an oracle with N allowed inputs. For one input w ("the winner") the corresponding output is 1, and for all other inputs the corresponding output is 0. The task is to find w. [...]

questa è la definizione che conoscevamo già.

> This has algorithm has subsequently been generalized to search in the presence of multiple "winners" [15], [...]
> 
> [15] M. Boyer, G. Brassard, P. Høyer, and A. Tapp 
Tight bounds on quantum searching. 
Fortschritte der Physik, 46:493-505, 1998. 

Questa generalizzazione non basta a risolvere il nostro problema, perché noi non vogliamo avere necessariamente "multiple winners", ma vogliamo limitare lo spazio di ricerca ad un database in memoria.

> One of the natural applications for Grover search is speeding up the solution to NP-complete problems such as 3-SAT. [...]

Da qui prendiamo atto che almeno per qualcosa l'algoritmo può essere usato.

> A problem closely related to, but harder than, Grover search, is spatial search, in which database queries are limited by some graph structure. On sufficiently well-connected graphs, O(√n) quantum query complexity is still achievable [274, 275, 303, 304, 305, 306, 330].

Questa cosa potrebbe essere interessante per il nostro caso di ricerca su un grafo, ma l'argomento sembra particolarmente complesso. Per capire di cosa si tratta riporto una definizione da Wikipedia:

> A **spatial database** is a database that is optimized for storing and querying data that represents objects defined in a geometric space.

#### Ordered search

> **Speedup:** Constant factor 
**Description:** We are given oracle access to a list of N numbers in order from least to greatest. Given a number x, the task is to find out where in the list it would fit. 

Possiamo già escludere a priori questo tipo di ricerca. Il nostro algoritmo prevede di cercare tra i vari archi connessi ad un nodo, quelli che hanno costo 'infinito'. Se avessimo gli archi già ordinati per costo allora il problema sarebbe risolto, prendendo gli archi all'estremo della lista.

#### Altri paper con titoli apparentemente interessanti

> [133] Quantum search algorithms
https://arxiv.org/abs/quant-ph/0504012

Buono per cultura personale, ma gli algoritmi non sono utili al nostro scopo.

> [137] Single quantum querying of a database
https://arxiv.org/abs/quant-ph/9705041

Vari algoritmi che risolvono con una singola quantum query problemi quali "parity problem", "coin weighing" ecc... Ancora non utile al nostro scopo.


## 25/04/2019 - Samuele

Come già visto implementazioni (anche in Q#) della Grover Search su database impliciti.
La differenza tra database implciti e reali è spiegata dal paper "Quantum search of a real unstructured database":

> Originally, the Grover search algorithm was called the database search algorithm, but the word “database” was later dropped. To retain the term “database search” one should distinguish two qualitatively distinct categories of databases [3–5]: the real (actual or explicit) database, which is a database in conventional meaning, and the virtual (abstract or implicit) database, which is a search space in the meaning of [1]. Roughly speaking, the real database represents data stored in a physical memory device, whereas the virtual one is not actually a database at all. Evidently, most of the existing literature is devoted to quantum search of virtual databases

Tuttavia molti concordano che Grover è utilizzabile e limitato solo ai database impliciti, come spiegato nel paper "Is Quantum Search practical?":

> Grover’s search algorithm seems confined to implicit databases, where it also faces serious competition from classical parallel methods.

Altre discussioni interessanti che in parte confermano questa idea le ho raccolte nel file "Papers > Quantum_search > Useful discussions"

Sono quindi arrivato alla conclusione che: **l'utilizzo di Grover** come algoritmo per la ricerca del prossimo arco da considerare per la MFA (come consigliato nel paper "Quantum Algorithm Implementations for Beginners") **è praticamente infattibile** data la discrepanza tra l'obiettivo originale dell'algoritmo e l'obiettivo che gli si dà in quel paper.

Grover è un algoritmo che può funzionare come invertitore di funzione one-way (utile in crittografia e hashing) ma la sua utilità decade come algoritmo di ricerca in lista o in database.

## 24/04/2019 - Samuele

**Premessa**: il nostro algoritmo di Quantum Max Flow Analysis, basa il suo motivo di esistere nel fatto che una piccola routine dell'algoritmo (la ricerca del prossimo arco da considerare tra quelli uscenti da un determinato nodo) venga fatta da un computer quantistico. Si tratta quindi, di fatti, di una ricerca in una lista (o più genericamente in una tabella/database) di uno o più elementi che soddisfino una certa condizione (in particolare che gli archi non siano stati visitati e quindi abbiano valore di peso == infinito).

Ho lavorato a una dimostrazione pratica della **Grover search** su database implicito (registo che può assumere tutti i valori), **implementata in Q#**. Ho ottenuto dei risultati statistici, a mio parere interessanti, che confermano quelli teorici. I risultati, di facile lettura, si possono trovare nella cartella "MFA_Samuele > outcomes > DatabaseSearch".

In particolare sono partito da un'implementazione dell'Amplitude Amplification presente nella libreria Canon del Microsoft QDK e altre funzioni suggerite da Microsoft per la risoluzione del problema specifico, ottenendo quindi una routine quantum che dati più elementi target, riesce a trovarli come output del registro quantistico con una certa probabilità. La chiamata alla routine viene fatta tramite un programma in C# che si preoccupa di calcolare le varie statistiche e di stampare in modo carino i risultati.

## 23/04/2019 - Samuele

Ho aggiornato il codice che esegue l'**algoritmo di Edmonds-Karp per il Max Flow su computer classici**, suddividendolo in classi più organizzate e semplificando ancoradi più la funzione che andrebbe fatta in quantum, in modo da poterla sostituire con una eventuale futura routine.
Purtroppo ancora, seppur ridotta, è complicata da farla in quantum.

## 09/04/2019 - Samuele

Dal paper sugli algoritmi, algoritmo Max Flow, paragrafo B, pagina 40:
“The Quantum algorithm described by Ambainis and Spalek is a “quantized” version of the Edmonds-Karp algorithm [...]”

Edmonds Karp Max Flow Algorithm Tutorial (consiglio di vedere a velocità x2): https://www.youtube.com/watch?v=w3Nl2XA0pxA
vantaggi rispetto a Ford-Fulkerson: implementa Breadth First e non dipende dal flow.

Edmonds Karp in C#: https://gist.github.com/Eyas/7520781

Ho fatto alcune modifiche al codice e l’ho predisposto all’inserimento della funzione quantistica una volta che sarà stata realizzata

## 09/04/2019 - Moreno

Al momento il mio piano è quello di trovare un algoritmo basato sul individuare un augmenting path. Vorrei trovare un percorso dalla sorgente al pozzo del grafo (sink).
Parto dal considerare grafi aciclici, per poi eventualmente trovare il modo di escludere i cicli dai grafi ciclici.
Quello che sono riuscito a fare finora è:
- Dato un insieme di archi, selezionarne uno e uno solo casualmente tra questi. Mi serve per poter definire l'arco iniziale da scegliere. Se riuscirò a manipolare le probabilità riducendo la probabilità che venga scelto un arco che porta a un percorso morto, ho risolto il mio problema.
- Dato un arco, se e solo se questo è attivo, attiva anche il successivo se unico(per poter definire il concetto di flusso). Al momento riesco nell'obiettivo applicando un semplice CNOT. Devo controllare eventuali effetti collaterali a riguardo.

I miei attuali obiettivi sono:
- Provare a riapplicare il concetto "Dato un arco,se e solo se questo è attivo, attiva anche il successivo" se l'arco successore non fosse unico (ho alcune idee, riuserei il primo punto "selezionarne uno e uno solo casualmente tra questi", ma devo assicurarmi di formularlo in modo tale da annullare la scelta (ottenere come output tutti 0 al fine di trovare un modo per cui un percorso venga ridotto di probabilità se dovesse essere un percorso morto (per ora non ho idee sul come farlo, sto studiando Grover per capire come potrei manipolare le probabilità/pesi tra i vari percorsi).
- Simulare lo stato teorico della funzione d'onda su Q#( non ho ancora cercato come si possa fare).

Conclusioni di questa settimana:
- Quando simulati a mano, due qbit che non si toccano in realtà potrebbero avere un comportamento anomalo in cui si influenzano a vicenda
vedi il circuito, la funzione d'onda prima della misurazione
```
QO H H Measurement
QI
H Measurement
```
- Per quanto riguarda la rappresentazione del problema, è necessario utilizzare ALMENO un qbit per arco . La ragione per questa affermazione sta nel fatto che la rappresentazione come prodotto tensoriale (di Kronecker per essere precisi) una volta misurata collassa praticamente in un array di bits. Per poter rappresentare senza ambiguità tutte le possibili combinazioni dell'esito dell'alaoritmo (arco 1 oreso/non oreso. arco 2 oreso/non oreso....) servono almeno #(archi).

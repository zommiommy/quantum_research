# Updates log

### 25/04/2019

##### Samuele

Come già visto implementazioni (anche in Q#) della Grover Search su database impliciti.
La differenza tra database implciti e reali è spiegata dal paper "Quantum search of a real unstructured database":

> Originally, the Grover search algorithm was called the database search algorithm, but the word “database” was later dropped. To retain the term “database search” one should distinguish two qualitatively distinct categories of databases [3–5]: the real (actual or explicit) database, which is a database in conventional meaning, and the virtual (abstract or implicit) database, which is a search space in the meaning of [1]. Roughly speaking, the real database represents data stored in a physical memory device, whereas the virtual one is not actually a database at all. Evidently, most of the existing literature is devoted to quantum search of virtual databases

Tuttavia molti concordano che Grover è utilizzabile e limitato solo ai database impliciti, come spiegato nel paper "Is Quantum Search practical?":

> Grover’s search algorithm seems confined to implicit databases, where it also faces serious competition from classical parallel methods.

Altre discussioni interessanti che in parte confermano questa idea le ho raccolte nel file "Papers > Quantum_search > Useful discussions"

Sono quindi arrivato alla conclusione che: **l'utilizzo di Grover** come algoritmo per la ricerca del prossimo arco da considerare per la MFA (come consigliato nel paper "Quantum Algorithm Implementations for Beginners") **è praticamente infattibile** data la discrepanza tra l'obiettivo originale dell'algoritmo e l'obiettivo che gli si dà in quel paper.

Grover è un algoritmo che può funzionare come invertitore di funzione one-way (utile in crittografia e hashing) ma la sua utilità decade come algoritmo di ricerca in lista o in database.

### 24/04/2019

##### Samuele

**Premessa**: il nostro algoritmo di Quantum Max Flow Analysis, basa il suo motivo di esistere nel fatto che una piccola routine dell'algoritmo (la ricerca del prossimo arco da considerare tra quelli uscenti da un determinato nodo) venga fatta da un computer quantistico. Si tratta quindi, di fatti, di una ricerca in una lista (o più genericamente in una tabella/database) di uno o più elementi che soddisfino una certa condizione (in particolare che gli archi non siano stati visitati e quindi abbiano valore di peso == infinito).

Ho lavorato a una dimostrazione pratica della **Grover search** su database implicito (registo che può assumere tutti i valori), **implementata in Q#**. Ho ottenuto dei risultati statistici, a mio parere interessanti, che confermano quelli teorici. I risultati, di facile lettura, si possono trovare nella cartella "MFA_Samuele > outcomes > DatabaseSearch".

In particolare sono partito da un'implementazione dell'Amplitude Amplification presente nella libreria Canon del Microsoft QDK e altre funzioni suggerite da Microsoft per la risoluzione del problema specifico, ottenendo quindi una routine quantum che dati più elementi target, riesce a trovarli come output del registro quantistico con una certa probabilità. La chiamata alla routine viene fatta tramite un programma in C# che si preoccupa di calcolare le varie statistiche e di stampare in modo carino i risultati.

### 23/04/2019

##### Samuele

Ho aggiornato il codice che esegue l'**algoritmo di Edmonds-Karp per il Max Flow su computer classici**, suddividendolo in classi più organizzate e semplificando ancoradi più la funzione che andrebbe fatta in quantum, in modo da poterla sostituire con una eventuale futura routine.
Purtroppo ancora, seppur ridotta, è complicata da farla in quantum.

### 09/04/2019

##### Samuele

Dal paper sugli algoritmi, algoritmo Max Flow, paragrafo B, pagina 40:
“The Quantum algorithm described by Ambainis and Spalek is a “quantized” version of the Edmonds-Karp algorithm [...]”

Edmonds Karp Max Flow Algorithm Tutorial (consiglio di vedere a velocità x2): https://www.youtube.com/watch?v=w3Nl2XA0pxA
vantaggi rispetto a Ford-Fulkerson: implementa Breadth First e non dipende dal flow.

Edmonds Karp in C#: https://gist.github.com/Eyas/7520781

Ho fatto alcune modifiche al codice e l’ho predisposto all’inserimento della funzione quantistica una volta che sarà stata realizzata

##### Moreno

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

**1)Ce este un viewport?**          					
Sistemul de ferestre, nu OpenGL, este responsabil pentru deschiderea unei ferestre pe ecran. Cu toate acestea, în mod implicit, fereastra este setată pe întregul dreptunghi de pixeli al ferestrei deschise. De exemplu, puteți subdiviza fereastra pentru a crea un efect de ecran divizat pentru mai multe vizualizări în aceeași fereastră.

**2) Ce reprezintă conceptul de frames per seconds din punctul de vedere al bibliotecii OpenGL?**
Rata cadrelor (exprimată în cadre pe secundă sau FPS) este frecvența (rata) la care sunt capturate sau afișate imaginile consecutive (cadre). Termenul se aplică în mod egal camerelor de film și video, grafică pe computer și sistemelor de captare a mișcării. Rata cadrelor poate fi numită și frecvența cadrelor și poate fi exprimată în hertz. Rata cadrelor în specificațiile camerei electronice se poate referi la rata maximă posibilă, unde, în practică, alte setări (cum ar fi timpul de expunere) pot reduce frecvența la un număr mai mic.

**3) Când este rulată metoda OnUpdateFrame()?**
Metoda OnUpdateFrame() se executa imediat dupa metoda OnLoad() si OnResize().

**4) Ce este modul imediat de randare?**
OpenGL are funcții de mod imediat care pot utiliza obiecte de server definite anterior (texturi, tampoane de vârf și tampoane de index, umbrere etc.) fără a retrimite date neschimbate. Modul mediu în grafica computerizată este un model de proiectare a proiectării API în bibliotecile grafice, în care apelurile clientului cauzează direct redarea obiectelor grafice pe afișaj sau în care datele pentru descrierea primitivelor de redare sunt inserate cadru cu cadru direct de la client într-o listă de comenzi (în cazul redării primitive în mod imediat), fără utilizarea unei indirecții extinse - deci imediate - a resurselor reținute.

**5) Care este ultima versiune de OpenGL care acceptă modul imediat?**
Ultima versiune de OpenGL care accepta modul imediat este OpenGL 3.2.x.

**6) Când este rulată metoda OnRenderFrame()?**
Metoda OnRenderFrame() este executata imediat dupa executia metodei OnUpdateFrame().

**7) De ce este nevoie ca metoda OnResize() să fie executată cel puțin o dată?**	
Metoda OnResize() tebuie să fie executată cel puțin o dată deoarece fereastra se modifica cel putin odata de la deschidere facand fullScreen .

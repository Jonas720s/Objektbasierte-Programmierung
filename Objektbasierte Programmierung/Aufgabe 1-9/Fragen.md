	1. Wie koennen Felder von Eigenschaften unterschieden werden? Oder anders gefragt: Woran ist bei einer Instanzvariable in C# erkennbar, ob es ein Feld oder eine Eigenschaft ist?
    Fuer Eigenschaften wird die PascalCase-Schreibeweise verwendet
	2. Worin unterscheidet sich ein backing field von einem normalen Feld?
    -Ein backingfield wird in verwendung mit einem Propertie genutzt ein normales field speichert einfach einen Wert
    -die Kontrolle ueber das backing field liegt in der Klasse
	3. Wann macht es Sinn, ein read-only Feld zu deklarieren, welches keinen Standardwert zugewiesen erhaelt?
    -wenn man den wert im Konstruktor initialisiert
	4. Wann macht es Sinn, ein read-only Feld zu deklarieren, welches einen Standardwert zugewiesen erhaelt?
    -wenn der Wert fix definiert ist
	5. Was sind typische Anwendungsfaelle fuer Felder in C#?
    Wenn eine Funktion in meheren Methoden verwendet wird und zum speichern von Daten
    6. Was sind typische Anwendungsfaelle fuer Eigenschaften in C#?
    zum validieren und setzen von werten.

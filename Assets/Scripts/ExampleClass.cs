// Bibliotheken / Asembly Referenz / Namespaces
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Deklaration einer Klasse

// public           -> access modifier (Zugriffsrechte) | keyword (vorreservierte Schlüsselwort)
// class            -> keyword zur Deklaration einer Klasse
// ExampleClass     -> identifier (Name der Klasse)
// : MonoBehaviour  -> Erstellen eine Unterklasse von MonoBehaviour
// {}               -> Scope/Wirkungsbereich (Was ist alles in der Klasse enthalten)
public class ExampleClass : MonoBehaviour
{
    // Deklaration von Variablen
    // Variablen sind Container für Value (Werte) oder References (Verweise)

    // Variablentypen mit Werten
    // public           -> access modifier (Wer darf von außen auf die Variable zugreifen)
    // int              -> Variablentyp (In diesem Fall Integer - Ganze Zahl)
    // ganzeZahlVariable-> identifier (Name der Variable)
    // ;                -> Ende des Statements (Deklaration der Variable)

    public int ganzeZahlVariable;  // Ganze Zahlen - Integer - Instanzvariable (innerhalb der ganzen Klasse gültig)
    // Gleitkommazahlen
    // Text
    // Binäre Entscheidung (Boolscher Wert)


    public void TestFunktion()
    {
        // Variable die NUR innerhalb der Funktion gültig ist
    }
}

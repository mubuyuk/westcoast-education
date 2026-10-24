# Westcoast Education

Ett konsolprogram utvecklat i C# som hanterar information om kurser, studenter och personal.

## Projektstruktur

Projektet är uppdelat i olika mappar där varje mapp har ett eget ansvarsområde. Det gör det enklare att hitta i koden och förstå vilken del av programmet som gör vad.

| Mapp | Beskrivning |
|---|---|
| `Models` | Här finns klasserna som beskriver programmets olika delar, exempelvis `Student`, `Teacher` och `Course`. Klasserna bestämmer vilka egenskaper och funktioner dessa objekt har. |
| `Managers` | Här finns klasser som hanterar samlingar av objekt. Exempelvis ansvarar `CourseManager` för att lägga till, kontrollera och visa kurser. |
| `Interfaces` | Här finns interface som bestämmer vilka metoder en klass måste ha, utan att bestämma exakt hur metoderna ska fungera. |
| `Storage` | Här finns klasser som ansvarar för att spara och läsa information från filer. I vårt projekt används JSON för att lagra kurser. |
| `Enums` | Här finns egna datatyper med ett begränsat antal fördefinierade alternativ. Exempelvis används `CourseType` för att ange om en kurs är på distans eller i klassrum. |
| `Data` | Här finns filen `courses.json`, där kursinformationen sparas så att den finns kvar även efter att programmet har avslutats. |

### Viktiga filer

- **`Program.cs`** – Här startar programmet. Vi skapar objekt och anropar metoder för att visa information om kurser, studenter och personal.
- **`ICourseStorage.cs`** – Ett interface som anger att en klass för kurslagring måste ha metoderna `SaveCourses()` och `LoadCourses()`.
- **`JsonCourseStorage.cs`** – Klassen som utför själva arbetet med att läsa och spara kurser i en JSON-fil. Den följer reglerna som definieras i `ICourseStorage`.
- **`courses.json`** – Filen där kursinformationen sparas i JSON-format.

### Hur kurshanteringen fungerar

När programmet startar försöker det läsa in kurser från `courses.json` med hjälp av metoden `LoadCourses()`.

Kurserna läggs sedan till i `CourseManager`, som håller reda på dem medan programmet körs.

Om inga kurser läses in skapar programmet två standardkurser. Dessa sparas sedan till JSON-filen med hjälp av metoden `SaveCourses()`.

När programmet startas nästa gång kan det läsa tillbaka de sparade kurserna.

Detta kallas **persistens**, vilket innebär att information kan sparas och finnas kvar även när programmet avslutas.
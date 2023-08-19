# Kilometer Beregner

Dette projekt handler om KilometerBeregner, en simpel C#-applikation, jeg har udviklet. Applikationen beregner prisen for en given mængde kørte kilometer baseret på bestemte prissatser. Jeg har skabt dette som en del af et kodningsprojekt for at demonstrere, hvordan man kan bruge objektorienteret programmering til at opbygge en kilometerberegner.

## Funktionalitet

Jeg har indbygget følgende funktionalitet i applikationen:

- Mulighed for at indtaste antal kilometer, der er blevet kørt.
- Automatisk beregning af prisen baseret på forskellige prissatser og kilometertærskler.
- Håndtering af eventuelle tillæg og særlige prissatser for bestemte områder.

## Klassestruktur

Projektet består primært af to vigtige komponenter:

- `KilometerBeregner`: En klasse, jeg har skrevet, der håndterer selve beregningen af prisen ud fra de fastlagte prissatser og kilometertærskler.
- `Program`: Dette er en intern klasse, der indeholder `Main`-metoden. Denne metode starter applikationen ved at oprette en instans af `KilometerBeregner`.

## Sådan bruger du applikationen

Her er trinene til at bruge min applikation:

1. Kør `KilometerBeregner.exe`.
2. Indtast det antal kilometer, du har kørt.
3. Applikationen beregner prisen og viser dig resultatet.

## Bemærkninger

- Dette projekt er udviklet som en del af mit læringsforløb og kan tilpasses eller udvides efter behov.
- Prissatserne og kilometertærsklerne er defineret som konstanter i `KilometerBeregner`-klassen. Du kan ændre dem, hvis det er nødvendigt.

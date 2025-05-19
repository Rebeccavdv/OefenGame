# OefenGame
Oefentoets:  Game
Je krijgt de taak om een applicatie te ontwikkelen die verschillende personages bevat, zoals een ridder, een tovenaar en een boogschutter. Deze personages moeten kunnen aanvallen, schade ontvangen en hun staat kunnen worden opgeslagen in een logboek. Daarnaast moeten de instellingen van de applicatie (zoals taal en volume) ook kunnen worden opgeslagen.

De scenario's die je programma moet doorlopen:
Sla de instellingen van de game op.,
Maak een ridder, tovenaar en boogschutter aan, elk met een specifieke naam en een HP van 50.,
Laat de personages aanvallen en laat hen schade ontvangen. Voeg elke actie toe aan het logboek.,
Toon het tot dus verre opgeslagen logboek en de instellingen.

🔹 Personage (abstracte klasse)
Attack() – Abstracte methode die door elke subklasse op een andere manier wordt geïmplementeerd. Dit bepaalt hoe het personage aanvalt (bijv. zwaard, magie, pijl).

TakeDamage(int schade) – Vermindert de HP van het personage en print dit uit. Subklassen kunnen deze methode overschrijven om schade op een unieke manier te verwerken (nodig voor de pantser bij de Ridder). De actie wordt ook teruggegeven in string formaat.

🔹 Ridder
Attack() – Print dat de ridder aanvalt met zijn zwaard. De actie word ook teruggegeven in string formaat.

TakeDamage() – Speciaal voor de Ridder -> past schade aan op basis van pantserwaarde: schade - pantser = werkelijke schade. 

🔹 Tovenaar
Attack() – Print dat de tovenaar een aanval uitvoert met zijn element (bijv. vuur, water). De actie word ook teruggegeven in string formaat.

🔹 Boogschutter
Attack() – Print dat de boogschutter een pijl schiet en verlaagt het aantal pijlen met 1. Als er geen pijlen meer zijn, wordt dat gemeld. De actie word ook teruggegeven in string formaat.

🔹 Logboek
VoegToe(string bericht) – Voegt een bericht toe aan de lijst van logs.

Save() – Print alle logregels naar de console als simulatie van alles wat er wordt opslagen.

🔹 Instellingen
Save() – Print de huidige instellingen (taal en volume) naar de console.

**UML: (klopt niet helemaal)**
![image](https://github.com/user-attachments/assets/30c7a854-6479-4398-b11b-2f0452d625bf)


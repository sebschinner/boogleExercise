# boogle
Simple Test Example for Candidates

Boogle ist eine Banjo Suchmaschine.

Folgende Funktionalitäten (je in der gekennzeichneten Funktion) sind zu implementieren:
1. Filter beim Laden der Banjos (index.js:12)
2. Hinzufügen eines neuen Banjos (index.js:50)
3. Falls neues Banjo schon vorhanden ist, vorhandenes Objekt aktualisieren (BanjoController.cs:23)

Starten des Clients (davor mit "npm i" die Abhängigkeiten installieren):
```javascript
node .\client\app\index.js
```
Starten des Servers:
```javascript
dotnet run --project .\server\Boogle\Boogle\Boogle.csproj
```

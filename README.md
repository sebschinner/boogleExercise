# boogle
Simple Test Example for Candidates

Boogle ist eine Banjo Suchmaschine.

## Aufgabenstellung

Folgende Funktionalitäten (je in der gekennzeichneten Funktion) sind zu implementieren:
1. Filter beim Laden der Banjos (index.js:12)
2. Hinzufügen eines neuen Banjos (index.js:50)
3. Falls neues Banjo schon vorhanden ist, vorhandenes Objekt aktualisieren (BanjoController.cs:23)

## Requirements

- git
- node
- dotnet core SDK

## Building and Running the project

1. Clone the source code
```bash
git clone https://github.com/sebschinner/boogleExercise.git
```

2. Install developer depencies
```bash
cd /client
npm install
```

3. change directory back to root
```bash
cd ..
```

4. Starting the Client
```bash
node .\client\app\index.js
```
5. Starting the Server:
```bash
dotnet run --project .\server\Boogle\Boogle\Boogle.csproj
```
